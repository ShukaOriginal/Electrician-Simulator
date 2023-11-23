using Electric_simulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electric_simulator.Forms
{
    public class SortCreatedElementModel
    {

        //private Array List1 { get; set; }

        public void SortingCreatedElements()
        {
            var List1 = ElementsModel.CreatedElements;
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
            ElementsModel.CreatedElements = List1;
        }
    }
}
