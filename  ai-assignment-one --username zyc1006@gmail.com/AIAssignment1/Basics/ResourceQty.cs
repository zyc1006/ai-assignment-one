using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1.Basics
{
    /**
     * <summary>
     * Used to define a quantity of a given resource.
     * </summary>
     */
    public class ResourceQty
    {
        public Resource Resource { get; private set; }
        public int Quantity { get; private set; }

        public ResourceQty(Resource r, int quantity)
        {
            Resource = r;
            Quantity = quantity;
        }
    }
}
