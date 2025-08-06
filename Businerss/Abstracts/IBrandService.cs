using Businerss.Dtos.Requests;
using Businerss.Dtos.Responses;
using Entites.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businerss.Abstracts;

public interface IBrandService
{
  
    CreatedBrandResponse Add(CreatedBrandRequest createdBrandRequest);
    List<GetAllBrandResponse> GetAll();
    //responses (istek) and requests  (yanıt)
}
