﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosedXML.Excel
{
    public interface IXLSortElements: IEnumerable<IXLSortElement>
    {
        void Add(Int32 elementNumber);
        void Add(Int32 elementNumber, XLSortOrder sortOrder);
        void Add(Int32 elementNumber, XLSortOrder sortOrder, Boolean ignoreBlanks);
        void Add(Int32 elementNumber, XLSortOrder sortOrder, Boolean ignoreBlanks, Boolean matchCase);

        void Add(String elementNumber);
        void Add(String elementNumber, XLSortOrder sortOrder);
        void Add(String elementNumber, XLSortOrder sortOrder, Boolean ignoreBlanks);
        void Add(String elementNumber, XLSortOrder sortOrder, Boolean ignoreBlanks, Boolean matchCase);

        void Clear();
    }
}
