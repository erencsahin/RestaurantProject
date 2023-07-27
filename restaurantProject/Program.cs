                                            /****************************************************************************
                                            **				       	SAKARYA ÜNÝVERSÝTESÝ                               **
                                            **				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ                  **
                                            **				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ                         **
                                            **				   NESNEYE DAYALI PROGRAMLAMA DERSÝ                        **
                                            **					    2022-2023 YAZ DÖNEMÝ                               **
                                            **	                                                                       **
                                            **				ÖDEV NUMARASI..........: 1                                 **
                                            **				ÖÐRENCÝ ADI............: EREN CAN ÞAHÝN                    **
                                            **				ÖÐRENCÝ NUMARASI.......: G211210088                        **
                                            **                         DERSÝN ALINDIÐI GRUP...:1/A                     **
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