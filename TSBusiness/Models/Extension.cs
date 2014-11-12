using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace TSBusiness.Models
{
    public static class Extension
    {
        public static MvcHtmlString EnumDropDownListFor<TModel, TProperty, TEnum>(
                    this HtmlHelper<TModel> htmlHelper,
                    Expression<Func<TModel, TProperty>> expression,
                    TEnum selectedValue)
        {
            var vals = Enum.GetValues(typeof(TEnum));
            var items = (from TEnum val in vals
                select new SelectListItem() {
                    Text = Enum.GetName(typeof (TEnum), val), Value = val.ToString(), Selected = (val.Equals(selectedValue))
                }).ToList();

            return SelectExtensions.DropDownListFor(htmlHelper, expression, items);
        }
    }
}