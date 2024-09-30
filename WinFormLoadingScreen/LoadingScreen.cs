using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


//COMMENT AUTOMATIC GENERATED WITH CHATGPT


namespace WinFormLoadingScreen
{
    public class LoadingForm
    {
        // LOADING FORM COMPONENTS
        private Form LoadForm; // Form to display the loading screen
        private PictureBox pbAnimationGIF; // PictureBox to display the GIF animation
        private System.Drawing.Image LoadingGIF; // The GIF image to display in the PictureBox
        private Color TransparencyColor; // Contain the color Transparency

        private Thread load_thread; // Thread to handle the loading of the form
        private Thread ShowThread; // Thread to display the form

        private bool is_running = false; // Variable to prevent multiple launches of the form

        // Constructor, accepts a GIF image to display
        public LoadingForm(System.Drawing.Image _loadingGIF)
        {
            LoadingGIF = _loadingGIF; // Initialize the loading GIF
        }

        // Method to launch the loading screen
        public void LaunchLoading()
        {
            // If the form is already running, exit; otherwise, set is_running to true
            if (is_running) return;
            else is_running = true;

            LoadForm = new Form(); // Create a new instance of the loading form
            InitializeForm(); // Initialize form properties

            load_thread = new Thread(HandleLaunchLoading); // Create a separate thread to handle the loading
            try
            {
                load_thread.Start(); // Start the loading thread
            }
            catch (Exception ex)
            {
                MessageBoxError(ex.ToString()); // Display an error message if something goes wrong
            }
        }

        // Method to stop the loading screen and hide the form
        public void StopLoading()
        {
            // Check if the operation to hide the form is requested from a different thread than the UI
            if (LoadForm.InvokeRequired)
            {
                // If so, use Invoke to execute the code on the UI thread
                LoadForm.Invoke(new Action(() =>
                {
                    LoadForm.Hide(); // Hide the form
                    LoadForm.Visible = false; // Set the form visibility to false
                    System.Windows.Forms.Application.ExitThread(); // Close the message loop of the secondary thread
                }));
            }
            else
            {
                // If already on the UI thread, execute the code directly
                LoadForm.Hide();
                LoadForm.Visible = false;
                System.Windows.Forms.Application.ExitThread(); // Close the message loop of the secondary thread
            }

            // Wait for the thread showing the form to complete
            if (ShowThread != null && ShowThread.IsAlive)
            {
                ShowThread.Join(); // Wait for the thread to finish
            }

            // Wait for the loading thread to complete
            if (load_thread != null && load_thread.IsAlive)
            {
                load_thread.Join(); // Wait for the thread to finish
            }

            is_running = false; // Set is_running to false to indicate the form is no longer running
        }

        // Method that handles launching the loading screen
        private void HandleLaunchLoading()
        {
            try
            {
                // Set the form's initial position to be centered relative to the screen
                LoadForm.StartPosition = FormStartPosition.CenterScreen;

                // Create a new thread to display the loading form
                ShowThread = new Thread(() =>
                {
                    LoadForm.Show(); // Show the loading form
                    System.Windows.Forms.Application.Run(); // Keep the form open in the secondary thread
                });

                ShowThread.Start(); // Start the thread that displays the form
            }
            catch (System.Exception ex)
            {
                MessageBoxError(ex.ToString()); // Display an error message in case of an exception
            }
        }

       public void SetTransparencyColor(Color color)
        {
            TransparencyColor = color;
        }

        // Method to initialize the form components
        private void InitializeForm()
        {
            // Initialize the PictureBox for the loading GIF
            pbAnimationGIF = new PictureBox();
            pbAnimationGIF.BackColor = Color.Transparent; // Set the background to transparent
            pbAnimationGIF.BackgroundImageLayout = ImageLayout.Stretch; // Set the image layout mode
            pbAnimationGIF.Dock = DockStyle.Fill; // Make the PictureBox fill the entire form
            pbAnimationGIF.Location = new Point(0, 0); // Set the location of the PictureBox
            pbAnimationGIF.Margin = new Padding(4, 3, 4, 3);
            pbAnimationGIF.Name = "pbAnimationGIF"; // Set the name of the PictureBox
            pbAnimationGIF.Size = new Size(317, 255); // Set the size of the PictureBox
            pbAnimationGIF.SizeMode = PictureBoxSizeMode.StretchImage; // The image will be resized to fit
            pbAnimationGIF.TabIndex = 43;
            pbAnimationGIF.TabStop = false;
            pbAnimationGIF.Image = LoadingGIF; // Set the GIF to display in the PictureBox
            pbAnimationGIF.BringToFront(); // Bring the PictureBox to the front

            // Configure the loading form
            LoadForm.AutoScaleDimensions = new SizeF(7F, 15F);
            LoadForm.AutoScaleMode = AutoScaleMode.Font; // Auto scale mode
            LoadForm.ClientSize = new Size(317, 255); // Set the form size
            LoadForm.ControlBox = false; // Remove the form's close button
            LoadForm.Controls.Add(pbAnimationGIF); // Add the PictureBox to the form
            LoadForm.FormBorderStyle = FormBorderStyle.None; // Remove the form's borders
            LoadForm.Margin = new Padding(4, 3, 4, 3);
            LoadForm.Name = "LoadingScreen"; // Set the form name
            LoadForm.ShowInTaskbar = false; // Don't show the form in the taskbar
            LoadForm.BackColor = TransparencyColor; // Set Form background to the same as TransparentKey
            LoadForm.TransparencyKey = TransparencyColor; //Set the color Transparency
        }

        // Method to display error messages in a MessageBox
        private void MessageBoxError(string message)
        {
            MessageBox.Show(message, "Loading Screen Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show the error message
        }
    }
}
