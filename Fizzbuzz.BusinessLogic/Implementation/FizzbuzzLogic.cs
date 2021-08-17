﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.BusinessLogic.Interface;

namespace Fizzbuzz.BusinessLogic.Implementation
{
    public class FizzbuzzLogic : IFizzbuzzLogic
    {
        private IEnumerable<IRule> _rules;
        private IDateTimeProvider _dateTimeProvider;

        public FizzbuzzLogic(IEnumerable<IRule> _rules, IDateTimeProvider _dateTimeProvider)
        {
            this._rules = _rules;
            this._dateTimeProvider = _dateTimeProvider;
        }

        public List<string> GetFizzBuzzList(int QueryNumber, DayOfWeek CurrentDay)
        {
            List<string> FizzbuzzList = new List<string>();

            Enumerable.Range(1, QueryNumber).ToList().ForEach(index =>
            {
                var FizzbuzzString = new StringBuilder();
                this._rules.Where(rule => rule.IsMultiple(index)).ToList().ForEach(rule => FizzbuzzString.Append(rule.GetString(CurrentDay)).Append(""));

                FizzbuzzList.Add(FizzbuzzString.Length > 0 ? FizzbuzzString.ToString() : index.ToString());
            });

            return FizzbuzzList;
        }

    }
}
