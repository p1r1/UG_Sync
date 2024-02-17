using System;
using UGCore;

namespace UGSyncUI {
    public static class ControlEx {
        ///txtbox1.Invoke(() => toolStripProgressBar1.Value = value);  textboxtan progresbar cagır
        public static void Invoke(this System.Windows.Forms.Control @this, Action action, bool appendLog = true) {
            if (@this == null) throw new ArgumentNullException("@this");
            if (action == null) throw new ArgumentNullException("action");
            if (@this.InvokeRequired) {
                @this.Invoke(action);
            }
            else {
                action();
            }

            if (appendLog) {
                //Console.WriteLine(@this.Text.ToString());
                //UGLog.appendTextToFile(@this.Text.ToString());

                //UGLog uLog = new UGLog();
                string filePath = AppDomain.CurrentDomain.BaseDirectory + "Info_" + DateTime.Now.ToString("dd-MM-yyyy_HH") + ".log";
                Log.append(@this.Text.ToString(), filePath);
            }
        }
    }

}
//private void foo () {
//    MethodInvoker mi = new MethodInvoker(() => progressBar.Progress = newProgressValue);
//    if (progressBar.InvokeRequired) {
//        progressBar.Invoke(mi);
//    }
//    else {
//        mi.Invoke();
//    }
//}

/// <summary>
/// Delegates for multithread 
/// use callback and crossthread platform usage
/// </summary>

/// InfoLabel
//delegate void SetTextCallback(string text);

//private void SetText(string text) {
//    / InvokeRequired required compares the thread ID of the
//    / calling thread to the thread ID of the creating thread.
//    / If these threads are different, it returns true.
//    if (this.labelInfo.InvokeRequired) {
//        SetTextCallback d = new SetTextCallback(SetText);
//        this.Invoke(d, new object[] { text });
//    }
//    else {
//        this.labelInfo.Text = text;
//    }
//}

