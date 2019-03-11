using Csla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CslaMobileFormatterBug
{
    [Serializable]
    public class SimpleBusinessObject : BusinessBase<SimpleBusinessObject>
    {
        private static readonly PropertyInfo<int> _id = RegisterProperty<int>(p => p.Id);

        public int Id
        {
            get => GetProperty(_id);
            set => SetProperty(_id, value);
        }

        private static readonly PropertyInfo<string> _name = RegisterProperty<string>(p => p.Name);

        public string Name
        {
            get => GetProperty(_name);
            set => SetProperty(_name, value);
        }

        [RunLocal]
        protected override void DataPortal_Create() => base.DataPortal_Create();
    }
}
