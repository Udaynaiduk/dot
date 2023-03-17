using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace Carts.Filters
{
    public class CartException:ExceptionFilterAttribute
    {
       
            public override void OnException(ExceptionContext context)
            {
                if (context == null)
                {
                    if (context.Exception is DbUpdateException)
                    {
                        Console.WriteLine(context.Exception.Message);
                    }
                }
            }

        }
    }

