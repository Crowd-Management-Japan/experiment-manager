# Simple Experiment Manager
This program was developed to assist in experiments with human participants, especially those filmed using video cameras. The program allows for the automatic termination of an experiment after a specified duration, ensuring that all experiments with the same conditions last for a consistent amount of time, and instructions remain consistent across trials. Additionally, the program enables the setup of any number of remote displays showing a centralized time so that multiple cameras can be easily and accurately synchronized.

# Using the Software as a Standalone Program
If you wish to use a single computer without any remote (wireless) display, you may simply use this program as is. An executable exe file can be found in the repository, in addition to an installation package. Simply run the program and define the settings needed for your experiments. A simple guide is provided below.

# Using the Software with WiFi-Connected Remote Displays
You can connect any number of displays (standalone PCs) to show the same centralized time and ensure that every camera is synchronized for the start of each trial. To do this, all PCs have to be connected to the same network. You basically need to use a WiFi router and ensure that all devices are connected to the same SSID.

# Time Settings
Here, you can set up how the time is visualized. If you use a second display connected to your PC, the time will be shown there. If a small display is used or a camera is set far from the display, it is possible that the time cannot be read. To ensure that synchronization with the start of the experiment is still possible, the display color will change at a given interval. Frequency is simply the update rate for the time. High frequency may lead to slightly high CPU and/or GPU usage (especially for old PCs). In "Experiment mode," the experiment name and time are shown in the time display. If this option is not checked, PC time is shown the entire time.

# Remote Display
Here, you can provide the IP addresses for all connected displays. Click "Add" to add a display and highlight the one you want to remove before hitting "Remove." Once the option is checked, data is sent to all displays through the UDP protocol. The displayed IP address is that of the local machine.

# Time Control Panel
This panel can be used to set the length of the experiment, automatically stop it when the time is over, and provide a vocal start/stop to participants. A countdown can also be set to allow some time before experiments actually start. The "Extend" option allows extending experiments when "Auto stop" is set. For example, you can extend experiments by 15 seconds if you judge an extension is needed by clicking "Extend" during each experiment. Start and stop messages are provided in 7 different languages with two different formats for the start.

# Experiment Name and Comments
You provide the name of each experiment, and it will be shown on the external and remote displays. If the last two characters are numeric, the name is automatically updated. For example, "Condition A, Rep. 01" will change to "Condition A, Rep. 02" at the end of the first repetition. You can also click on "Add comment" to include comments during the experiment (for example, if you believe there was some external bias and that the experiment needs to be considered more carefully). You can choose to overwrite files with the same name (good for testing) or ensure that files are never overwritten (good during real experiments).
