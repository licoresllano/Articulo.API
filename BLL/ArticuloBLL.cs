using System;
using System.Collections.Generic;

namespace BLL
{
    public class ArticuloBLL
    {
        public List<ArticuloBLL> obtenerArticulo()
        {
            ArticuloDAL ArticuloDal = new ArticuloDAL();
            return ArticuloDal.obtenerArticulo();
        }

        public object obtenerArticulos()
        {
            throw new NotImplementedException();
        }
    }
}
