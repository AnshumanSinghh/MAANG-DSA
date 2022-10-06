using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Assignment_7
{
    class Collinear
    {
        /// <summary>
        /// Checks whether 3 points are collinear or not.
        /// </summary>
        /// <param name="points">Contains Co-Ordinates of three points</param>
        /// <remarks>Time Complexity = O(1) and Space Complexity = O(1)</remarks>
        /// <returns>"Yes" / "No"</returns>
        public string CheckIfCollinear(List<List<int>> points)
        {
            /*
             For Collinearity of 3 points, we have 3 ways to prove:
            1) Slope of AB = Slope BC  
            2) AB + BC = AC  [In case of Equilateral triangle it will be 'True' too]
            3) Area of triange = 0; [as they all lie on same line height will be zero so the area will be 0 too.]
            Since, area is zero we can say that if determinant is zero area will be zero. Because area = 1/2 * (determinant of 3 points)

            Here we can either go with 1st or 3rd condition as 2nd condition can be 'True' for non-collinear points also.
             */
            // points = {{x1, y1}, {x2, y2}, {x2, y3}}

            var x1 = points[0][0];
            var y1 = points[0][1];
            var x2 = points[1][0];
            var y2 = points[1][1];
            var x3 = points[2][0];
            var y3 = points[2][1];

            // Calculate the Determinant of triangle
            var determinantOfThreePoints = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            if (determinantOfThreePoints == 0)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
