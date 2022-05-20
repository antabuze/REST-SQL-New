using HotChocolate;
using HotChocolate.Data;
using REST_SQL_New.Models;
using System.Collections.Generic;
using System.Linq;

namespace REST_SQL_New.Data
{
    public class Query
    {
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Athlete> GetAthletes([Service] AthleteContext context) =>
            context.Athletes;

        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Coach> GetCoaches([Service] CoachContext context) =>
            context.Coaches;

        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Medal> GetMedals([Service] MedalContext context) =>
            context.Medals;

        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<MedalTotal> GetMedalTotals([Service] MedalTotalContext context) =>
            context.medals_total;
    }
}
