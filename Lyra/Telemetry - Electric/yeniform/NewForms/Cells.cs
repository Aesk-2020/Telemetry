using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemetri.Variables;

namespace Telemetri.NewForms
{
    public partial class Cells : Form
    {
        public Cells()
        {
            InitializeComponent();
            UITools.CellsForm.cellsVoltBoxList.Add(cell1Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell2Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell3Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell4Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell5Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell6Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell7Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell8Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell9Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell10Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell11Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell12Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell13Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell14Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell15Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell16Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell17Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell18Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell19Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell20Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell21Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell22Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell23Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell24Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell25Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell26Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell27Vbox);
            UITools.CellsForm.cellsVoltBoxList.Add(cell28Vbox);

            UITools.CellsForm.cellsSocBoxList.Add(cell1socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell2socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell3socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell4socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell5socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell6socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell7socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell8socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell9socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell10socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell11socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell12socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell13socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell14socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell15socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell16socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell17socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell18socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell19socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell20socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell21socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell22socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell23socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell24socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell25socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell26socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell27socBox);
            UITools.CellsForm.cellsSocBoxList.Add(cell28socBox);

            UITools.CellsForm.cellsTempBoxList.Add(cell1tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell2tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell3tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell4tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell5tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell6tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell7tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell8tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell9tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell10tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell11tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell12tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell13tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell14tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell15tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell16tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell17tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell18tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell19tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell20tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell21tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell22tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell23tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell24tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell25tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell26tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell27tempBox);
            UITools.CellsForm.cellsTempBoxList.Add(cell28tempBox);

        }
        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        #endregion

        #region .. code for Flucuring ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        private void Cells_Load(object sender, EventArgs e)
        {
            #region doubleBuffer
            SetDoubleBuffered(tableLayoutPanel1);
            SetDoubleBuffered(tableLayoutPanel2);
            SetDoubleBuffered(tableLayoutPanel3);
            SetDoubleBuffered(tableLayoutPanel4);
            SetDoubleBuffered(tableLayoutPanel5);
            SetDoubleBuffered(tableLayoutPanel6);
            SetDoubleBuffered(tableLayoutPanel7);
            SetDoubleBuffered(tableLayoutPanel8);
            SetDoubleBuffered(tableLayoutPanel9);
            SetDoubleBuffered(tableLayoutPanel10);
            SetDoubleBuffered(tableLayoutPanel11);
            SetDoubleBuffered(tableLayoutPanel12);
            SetDoubleBuffered(tableLayoutPanel13);
            SetDoubleBuffered(tableLayoutPanel14);
            SetDoubleBuffered(tableLayoutPanel15);
            SetDoubleBuffered(tableLayoutPanel16);
            SetDoubleBuffered(tableLayoutPanel17);
            SetDoubleBuffered(tableLayoutPanel18);
            SetDoubleBuffered(tableLayoutPanel19);
            SetDoubleBuffered(tableLayoutPanel20);
            SetDoubleBuffered(tableLayoutPanel21);
            SetDoubleBuffered(tableLayoutPanel22);
            SetDoubleBuffered(tableLayoutPanel23);
            SetDoubleBuffered(tableLayoutPanel24);
            SetDoubleBuffered(tableLayoutPanel25);
            SetDoubleBuffered(tableLayoutPanel26);
            SetDoubleBuffered(tableLayoutPanel27);
            SetDoubleBuffered(tableLayoutPanel28);
            SetDoubleBuffered(tableLayoutPanel29);
            SetDoubleBuffered(tableLayoutPanel30);
            #endregion

        }
    }
}
