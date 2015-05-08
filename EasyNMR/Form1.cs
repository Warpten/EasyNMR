using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BrightIdeasSoftware;

using EasyNMR.Internal;

namespace EasyNMR
{
    public partial class Form1 : Form
    {
        private List<PeakInfo> Peaks = new List<PeakInfo>();

        public Form1()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Generator.GenerateColumns(PeakView, typeof(PeakInfo), true);
        }

        private void AddPeak(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PPMShift.Text))
                return;

            PeakInfo peak = new PeakInfo();
            peak.Shift = float.Parse(PPMShift.Text);
            peak.Coupling = string.IsNullOrEmpty(Coupling.Text) ? "None" : Coupling.Text;

            peak.Type = (PeakType)SignalType.SelectedIndex;
            if ((int)peak.Type == -1)
                peak.Type = (PeakType)SignalType.Items.IndexOf(SignalType.Text);
            if ((int)peak.Type == -1)
                return;
            peak.HydrogenCount = int.Parse(HydrogenCount.Text);
            peak.Description = Description.Text;

            if (peak.Shift == 0.00f || peak.HydrogenCount == 0)
                return;

            PeakView.AddObject(peak);
            PeakView.Sort(0);

            SignalType.SelectedIndex = 0;
            SignalType.Text = String.Empty;
            PPMShift.Clear();
            HydrogenCount.Clear();
            Description.Clear();
            Coupling.Clear();
        }

        private void OnRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            if (e.Model == null)
                return;

            var removeItem = new ToolStripMenuItem();
            removeItem.Text = @"Supprimer";
            removeItem.Tag = e.RowIndex;
            removeItem.Click += (__, _) => {
                PeakView.RemoveObject(e.Model);
                PeakView.Refresh();
                PeakView.Sort(0);
            };

            var editItem = new ToolStripMenuItem();
            editItem.Text = @"Modifier";
            editItem.Tag = e.RowIndex;
            editItem.Click += (__, _) => {
                PeakView.EditSubItem(e.Item, e.ColumnIndex);
                PeakView.Sort(0);
            };

            e.MenuStrip = new ContextMenuStrip();
            e.MenuStrip.Items.Add(removeItem);
            e.MenuStrip.Items.Add(editItem);
        }

        private void ExportNMR(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
            var stringData = string.Join(",", PeakView.Objects.Cast<PeakInfo>());

            data.SetData(DataFormats.Rtf, stringData);
            Clipboard.SetText(stringData, TextDataFormat.Rtf);
        }
    }
}
