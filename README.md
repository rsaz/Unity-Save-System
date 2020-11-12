# Unity-Save-System
Generic Unity Saving System

<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
* [Usage](#usage)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)


<!-- ABOUT THE PROJECT -->
## About The Project

<!-- ![](https://github.com/rsaz/Unity2D-Player-Movement/blob/master/PlayerMovementScreen.PNG) -->

Project created to demonstrate a generic saving system that can be used in any game:
Scripts:
- SavingLoadingSystem : Responsible to define a temporary Context Menu Function to save and Load. Just one saving system per level is required
- LevelSystem : Is the class data structure that will be saved. You can change the data structure to suit your need
- ISaveable : interface created to define two main methods to save and restore data
- SaveableEntity : You can add this script to any object that you want to save data and it will automatically add the LevelSystem Script

Here's why:
* Your time should be focused on creating something amazing rather than recreating saving systems for every single game you build. You can take this code as a starting point. :smile:

### Built With
This section should list any major frameworks that you built your project using. Leave any add-ons/plugins for the acknowledgements section. Here are a few examples.
* [Unity Engine](https://unity.com/)
* [VS Community](https://visualstudio.microsoft.com/downloads/)

<!-- GETTING STARTED -->
## Getting Started

You are free to enhance this project sending your contribution, star and fork, or send suggestions.

### Prerequisites

[Unity Requirements](https://docs.unity3d.com/Manual/system-requirements.html)

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the original repository to your own repository
2. Clone it to your local
3. Contribute to it
4. Push it to your remote repo
5. Send a PR to the main repo
6. Your contribution will be evaluated then we will merge your changes with the original repository.

<!-- CONTACT -->
## Contact

Richard Zampieri - [twitch/id_akira](https://www.twitch.tv/id_akira) - Streaming channel

Game development portal Link: [Akira Game Dev](https://www.catarse.me/akiratv)
