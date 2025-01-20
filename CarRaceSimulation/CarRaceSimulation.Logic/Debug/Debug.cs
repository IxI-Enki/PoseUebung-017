///   N A M E S P A C E   ///
namespace CarRaceSimulation.Logic.Debug;

public class Debug
{
        #region OVERRIDES

        public override string ToString( ) => $"Instance of:  {THIS?.Property}";

        #endregion


        #region PROPERTIES

        public static Debug? THIS { get; private set; }

        internal string? Property { get; private set; }

        #endregion


        #region CONSTRUCTOR

        private Debug( string? db ) { Property = db; }

        static Debug( ) => THIS = new( db: "[default debug]" );

        #endregion
}
