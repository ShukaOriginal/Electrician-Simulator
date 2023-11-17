using Electric_simulator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electric_simulator.Forms
{
    public class SortCreatedElementModel
    {
        public ElementsModel data = new ElementsModel();

        //private Array List1 { get; set; }

        public void SortingCreatedElements()
        {
            var List1 = data.CreatedElements;
            //_ = data.CreatedElements[0];
            for (int j = 0; j < List1.Count; j++)
            {
                for (int i = 0; i < List1.Count - 1; i++)
                {
                    if (List1[i].type > List1[i + 1].type)
                    {
                        PropertiesObject mem = List1[i + 1];
                        List1[i + 1] = List1[i];
                        List1[i] = mem;
                    }
                }
            }
            data.CreatedElements = List1;
        }
    }
}
