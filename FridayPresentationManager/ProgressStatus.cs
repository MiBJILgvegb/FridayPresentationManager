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

        internal void Min(int min) { this.progressBar.Invoke(new Action(() => this.progressBar.Minimum = min ));  }
        internal int Min() { return this.progressBar.Minimum; }
        internal void Max(int max) { this.progressBar.Invoke(new Action(() => this.progressBar.Maximum = max ));  }
        internal void Step(int step) { this.progressBar.Invoke(new Action(() => this.progressBar.Step = step ));  }
        internal void PerfomsStep() { this.progressBar.Invoke(new Action(() => this.progressBar.PerformStep() ));  }
        internal void Status(string status="") { this.label.Invoke(new Action(() => this.label.Text = status ));  }
        internal void Value(int value) { this.progressBar.Invoke(new Action(() => this.progressBar.Value = value)); }
        internal void Visible(bool isVisible = false) { this.progressBar.Invoke(new Action(() => this.progressBar.Visible = isVisible)); }

        internal void UpdateStatus(string status = "")
        {
            PerfomsStep();
            Status(status);
        }
        internal void PBLimits(int[] limits)
        {
            this.Min(limits[0]);
            this.Max(limits[1]);
            this.Step(limits[2]);
        }
        internal void PBLimitsMin(int min) { this.Min(min); }
        internal void PBLimitsMax(int max) { this.Min(max); }
        internal void PBLimitsStep(int step) { this.Step(step); }

        public ProgressStatus(ProgressBar progressBar, System.Windows.Forms.Label label) 
        {
            this.progressBar = progressBar;
            Visible(true);
            this.label=label;
        }
        public void Destroy()
        {
            Status("");
            progressBar.Value = progressBar.Minimum;
        }
    }
}
