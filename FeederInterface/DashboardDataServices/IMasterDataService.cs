﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockModel.Master;
using System.Web.Mvc;

namespace StockInterface.DashBoardDataServices
{
    public interface IMasterDataService
    {
        IEnumerable<SelectListItem> GetDropDownData(DropDownRequest request);
    
    }
}
