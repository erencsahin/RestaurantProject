                                            /****************************************************************************
                                            **				       	SAKARYA �N�VERS�TES�                               **
                                            **				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�                  **
                                            **				    B�LG�SAYAR M�HEND�SL��� B�L�M�                         **
                                            **				   NESNEYE DAYALI PROGRAMLAMA DERS�                        **
                                            **					    2022-2023 YAZ D�NEM�                               **
                                            **	                                                                       **
                                            **				�DEV NUMARASI..........: 1                                 **
                                            **				��RENC� ADI............: EREN CAN �AH�N                    **
                                            **				��RENC� NUMARASI.......: G211210088                        **
                                            **                         DERS�N ALINDI�I GRUP...:1/A                     **
                                            ****************************************************************************/


namespace restaurantProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}