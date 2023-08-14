using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FridayPresentationManager
{
    internal class ProgressStatus
    {
        ProgressBar progressBar;
        System.Windows.Forms.Label label;

        private void Min(int min) { this.progressBar.Invoke(new Action(() => this.progressBar.Minimum = min ));  }
        private int Min() { return this.progressBar.Minimum; }
        private void Max(int max) { this.progressBar.Invoke(new Action(() => this.progressBar.Maximum = max ));  }
        private int Max() { return this.progressBar.Minimum; }
        private void Step(int step) { this.progressBar.Invoke(new Action(() => this.progressBar.Step = step ));  }
        internal void PerfomsStep() { this.progressBar.Invoke(new Action(() => this.progressBar.PerformStep() ));  }
        internal void Status(string status="") { this.label.Invoke(new Action(() => this.label.Text = status ));  }
        internal void Value(int value) { this.progressBar.Invoke(new Action(() => this.progressBar.Value = value)); }
        internal void Visible(bool isVisible=false) { this.progressBar.Invoke(new Action(() => this.progressBar.Visible = isVisible)); }

        internal void UpdateStatus(string status = "")
        {
            PerfomsStep();
            Status(status);
        }
        /*
         * Задает min, max, step параметры
         * array [int min,int max, intstep]  
         */
        internal void PBLimits(int[] limits)
        {
            this.Min(limits[0]);
            this.Max(limits[1]);
            this.Step(limits[2]);
        }
        internal void PBLimitsMin(int min) { this.Min(min); }
        internal int PBLimitsMin() { return this.Min(); }
        internal void PBLimitsMax(int max) { this.Max(max); }
        internal int PBLimitsMax() { return this.Max(); }
        internal void PBLimitsStep(int step) { this.Step(step); }

        public ProgressStatus(ProgressBar progressBar, System.Windows.Forms.Label label) 
        {
            this.progressBar = progressBar;
            this.label = label;
            //Visible(true);
        }
        public void Destroy()
        {
            Visible();
            Status("");
            Value(this.PBLimitsMin());
        }
    }
}
