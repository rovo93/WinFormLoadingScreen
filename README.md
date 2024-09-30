# Windows Form Loading Screen

How-To
1. Just add ref to "WinFormLoadingScreen.dll" to your Project
  
2. In primary Form declare the Loading Form:
    LoadingForm loadingForm = new LoadingForm(MyGifImage);

3. Optional: use loadingForm.SetTransparencyColor(Color.YourColor);

4. Use loadingForm.LaunchLoading(); to start Animation

5. Use loadingForm.StopLoading(); to end Animation


Example code:


        LoadingForm loadingForm = new LoadingForm(MyGifImage);

        public Form1()
        {
            InitializeComponent();
            loadingForm.SetTransparencyColor(Color.White);
        }


        private void btn5Second_Click(object sender, EventArgs e)
        {

            loadingForm.LaunchLoading();
            //DO STUFFS HERE
            System.Threading.Thread.Sleep(5000);
            loadingForm.StopLoading();

        }

