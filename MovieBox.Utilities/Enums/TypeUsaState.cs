#region Includes

// .NET Libraries
using System.ComponentModel;

#endregion

namespace Utilities
{
    /// <summary>
    /// Determines the state type.
    /// </summary>
    public enum TypeUsaState
    {
        /// <summary>
        /// Indicates an unidentified value.
        /// </summary>
        [Description("None Selected")]
        None = -1,

        /// <summary>
        /// Indicates Alabama.
        /// </summary>
        [Description("AL")]
        Alabama = 1,

        /// <summary>
        /// Indicates Alaska.
        /// </summary>
        [Description("AK")]
        Alaska = 2,

        /// <summary>
        /// Indicates Arizona.
        /// </summary>
        [Description("AZ")]
        Arizona = 3,

        /// <summary>
        /// Indicates Alabama.
        /// </summary>
        [Description("AR")]
        Arkansas = 4,

        /// <summary>
        /// Indicates California.
        /// </summary>
        [Description("CA")]
        California = 5,

        /// <summary>
        /// Indicates Colorado.
        /// </summary>
        [Description("CO")]
        Colorado = 6,

        /// <summary>
        /// Indicates Connecticut.
        /// </summary>
        [Description("CT")]
        Connecticut = 7,

        /// <summary>
        /// Indicates Delaware.
        /// </summary>
        [Description("DE")]
        Delaware = 8,

        /// <summary>
        /// Indicates Florida.
        /// </summary>
        [Description("FL")]
        Florida = 9,

        /// <summary>
        /// Indicates Georgia.
        /// </summary>
        [Description("GA")]
        Georgia = 10,

        /// <summary>
        /// Indicates Hawaii.
        /// </summary>
        [Description("HI")]
        Hawaii = 11,

        /// <summary>
        /// Indicates Idaho.
        /// </summary>
        [Description("ID")]
        Idaho = 12,

        /// <summary>
        /// Indicates Illinois.
        /// </summary>
        [Description("IL")]
        Illinois = 13,

        /// <summary>
        /// Indicates Indiana.
        /// </summary>
        [Description("IN")]
        Indiana = 14,

        /// <summary>
        /// Indicates Iowa.
        /// </summary>
        [Description("IA")]
        Iowa = 15,

        /// <summary>
        /// Indicates Kansas.
        /// </summary>
        [Description("KS")]
        Kansas = 16,

        /// <summary>
        /// Indicates Kentucky.
        /// </summary>
        [Description("KY")]
        Kentucky = 17,

        /// <summary>
        /// Indicates Louisiana.
        /// </summary>
        [Description("LA")]
        Louisiana = 18,

        /// <summary>
        /// Indicates Maine.
        /// </summary>
        [Description("ME")]
        Maine = 19,

        /// <summary>
        /// Indicates Maryland.
        /// </summary>
        [Description("MD")]
        Maryland = 20,

        /// <summary>
        /// Indicates Massachusetts.
        /// </summary>
        [Description("MA")]
        Massachusetts = 21,

        /// <summary>
        /// Indicates Michigan.
        /// </summary>
        [Description("MI")]
        Michigan = 22,

        /// <summary>
        /// Indicates Minnesota.
        /// </summary>
        [Description("MN")]
        Minnesota = 23,

        /// <summary>
        /// Indicates Mississippi.
        /// </summary>
        [Description("MS")]
        Mississippi = 24,

        /// <summary>
        /// Indicates Missouri.
        /// </summary>
        [Description("MO")]
        Missouri = 25,

        /// <summary>
        /// Indicates Montana.
        /// </summary>
        [Description("MT")]
        Montana = 26,

        /// <summary>
        /// Indicates Nebraska.
        /// </summary>
        [Description("NE")]
        Nebraska = 27,

        /// <summary>
        /// Indicates Nevada.
        /// </summary>
        [Description("NV")]
        Nevada = 28,

        /// <summary>
        /// Indicates New Hampshire.
        /// </summary>
        [Description("NH")]
        NewHampshire = 29,

        /// <summary>
        /// Indicates New Jersey.
        /// </summary>
        [Description("NJ")]
        NewJersey = 30,

        /// <summary>
        /// Indicates New Mexico.
        /// </summary>
        [Description("NM")]
        NewMexico = 31,

        /// <summary>
        /// Indicates New York.
        /// </summary>
        [Description("NY")]
        NewYork = 32,

        /// <summary>
        /// Indicates North Carolina.
        /// </summary>
        [Description("NC")]
        NorthCarolina = 33,

        /// <summary>
        /// Indicates North Dakota.
        /// </summary>
        [Description("ND")]
        NorthDakota = 34,

        /// <summary>
        /// Indicates Ohio.
        /// </summary>
        [Description("OH")]
        Ohio = 35,

        /// <summary>
        /// Indicates Oklahoma.
        /// </summary>
        [Description("OK")]
        Oklahoma = 36,

        /// <summary>
        /// Indicates Oregon.
        /// </summary>
        [Description("OR")]
        Oregon = 37,

        /// <summary>
        /// Indicates Pennsylvannia.
        /// </summary>
        [Description("PA")]
        Pennsylvannia = 38,

        /// <summary>
        /// Indicates Rhode Island.
        /// </summary>
        [Description("RI")]
        RhodeIsland = 39,

        /// <summary>
        /// Indicates South Carolina.
        /// </summary>
        [Description("SC")]
        SouthCarolina = 40,

        /// <summary>
        /// Indicates South Dakota.
        /// </summary>
        [Description("SD")]
        SouthDakota = 41,

        /// <summary>
        /// Indicates Tennessee.
        /// </summary>
        [Description("TN")]
        Tennessee = 42,

        /// <summary>
        /// Indicates Texas.
        /// </summary>
        [Description("TX")]
        Texas = 43,

        /// <summary>
        /// Indicates Utah.
        /// </summary>
        [Description("UT")]
        Utah = 44,

        /// <summary>
        /// Indicates Vermont.
        /// </summary>
        [Description("VT")]
        Vermont = 45,

        /// <summary>
        /// Indicates Virginia.
        /// </summary>
        [Description("VA")]
        Virginia = 46,

        /// <summary>
        /// Indicates Washington.
        /// </summary>
        [Description("WA")]
        Washington = 47,

        /// <summary>
        /// Indicates West Virginia.
        /// </summary>
        [Description("WV")]
        WestVirginia = 48,

        /// <summary>
        /// Indicates Wisconsin.
        /// </summary>
        [Description("WI")]
        Wisconsin = 49,

        /// <summary>
        /// Indicates Wyoming.
        /// </summary>
        [Description("WY")]
        Wyoming = 50,

        /// <summary>
        /// Indicates District of Columbia.
        /// </summary>
        [Description("DC")]
        DistrictOfColumbia = 51,

        /// <summary>
        /// Indicates American Samoa.
        /// </summary>
        [Description("AS")]
        AmericanSamoa = 52,

        /// <summary>
        /// Indicates Guam.
        /// </summary>
        [Description("GU")]
        Guam = 53,

        /// <summary>
        /// Indicates Northern Mariana Islands.
        /// </summary>
        [Description("MP")]
        NorthernMarianaIslands = 54,

        /// <summary>
        /// Indicates Puerto Rico.
        /// </summary>
        [Description("PR")]
        PuertoRico = 55,

        /// <summary>
        /// Indicates US Virgin Islands.
        /// </summary>
        [Description("VI")]
        UsVirginIslands = 56
    }
}
