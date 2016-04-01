using System;
using System.Windows.Input;

namespace PathButton
{
    public class DelegateCommand : ICommand
    {
        #region ICommand 成员

        public bool CanExecute(object parameter)
        {
            if (CanExecuteFunc == null)
            {
                return true;
            }

            return CanExecuteFunc(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (ExecuteAction == null)
            {
                return;
            }

            ExecuteAction(parameter);
        }

        #endregion

        public Action<object> ExecuteAction { get; set; }
        public Func<object, bool> CanExecuteFunc { get; set; }
    }

}
