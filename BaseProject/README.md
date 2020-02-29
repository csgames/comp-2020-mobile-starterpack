# Base project for the CS Games 2020 mobile competition

This project is provided as a preparation for your environments. As this year's mobile competition may require some important configuration, it seemed fair to give the starter project that will be provided during the competition beforehand. It contains an Android Solution and an iOS solution. These two solutions both reference the shared code library project. Please use this project to setup your personal environments before the competition takes place. This will prevent unwanted surprises on the day of the competition.

For Android, it would be worthwhile to do the following:

1. Install Visual Studio community edition.
2. Ensure the "Mobile development with .NET" and ".NET Core cross platform development" components are enabled. The correctors will compile on a VS having these installed.
3. If you already have VS installed but are unsure if you have these installed you can verify and edit your installation by following the steps here: https://docs.microsoft.com/en-us/visualstudio/install/modify-visual-studio?view=vs-2019
4. Install an emulator if you do not have an Android device. Steps for this can be found here: https://docs.microsoft.com/en-us/xamarin/android/get-started/installation/android-emulator/device-manager?tabs=windows&pivots=windows
5. If you attempt to start your emulator and encounter a WHPX (Hypervisor) error, you can enable it through the steps described here: https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v

During the event, each team will be provided with a Mac having the most up to date version of Visual Studio, XCode and the supporting Xamarin libraries.

For iOS, it would be worthwhile to do the following (whether you have a Mac or not):

1. Create an Apple ID account https://appleid.apple.com/#!&page=signin
2. (If you don't have a Mac, the following steps will need to be done on the day of the competition) Navigate to https://ionicframework.com/blog/deploying-to-a-device-without-an-apple-developer-account/ to set up your provisioning profile. Specifically, follow the steps outlined in the following sections: "Getting Set Up" which will allow you the log into XCode, "Code Signing in XCode" in the XCode 8+ section. This will allow you to create the provisioning profile on the Mac. Finally, the "Trusting the Certificate" section will explain how to allow your iOS device to run and debug your app.
3. Further information on this process can be found at the following StackOverflow URL: https://stackoverflow.com/questions/4952820/test-ios-app-on-device-without-apple-developer-program-or-jailbreak

**In the best case scenario you should be able to build and see the base project on both Android and iOS (assuming you have the hardware). You do not have the competition itself, but feel free to customize this project as you see fit. It will be similar to the one on the day of the competition.**

![alt text](https://i.gyazo.com/4fda71cd14d7c08fc3f35a26de981ec8.png "Composantes à installer")

# Project de base pour la compétition mobile CS Games 2020

Ce projet est fourni afin de vous permettre de préparer vos environnements. Comme la compétition mobile de cette année peut nécessiter une configuration importante, il nous a semblé juste de donner au préalable le projet de base qui sera fourni lors de la compétition. Ce projet contient une solution Android et une solution iOS. Ces deux solutions font référence au projet de code partagé. Veuillez utiliser ce projet pour configurer vos environnements personnels avant la compétition. Cela évitera des surprises indésirables le jour de la compétition.

Pour Android, il serait utile de procéder comme suit:

1. Installez Visual Studio Community Edition.
2. Assurez-vous que les composantes "Développement mobile avec .NET" et "Développement multiplateforme .NET Core" sont activés. Les correcteurs compileront sur un VS les ayant installés.
3. Si vous avez déjà installé VS mais ne savez pas si vous les avez installés, vous pouvez vérifier et modifier votre installation en suivant les étapes ici: https://docs.microsoft.com/fr-ca/visualstudio/install/modify-visual-studio?view=vs-2019
4. Installez un émulateur si vous ne disposez pas d'un appareil Android. Les étapes pour cela peuvent être trouvées ici: https://docs.microsoft.com/fr-ca/xamarin/android/get-started/installation/android-emulator/device-manager?tabs=windows&pivots=windows
5. Si vous essayez de démarrer votre émulateur et que vous rencontrez une erreur WHPX (hyperviseur), vous pouvez l'activer en suivant les étapes décrites ici: https://docs.microsoft.com/fr-ca/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v

Au cours de l'événement, chaque équipe recevra un Mac disposant de la version la plus récente de Visual Studio, XCode et des bibliothèques Xamarin.

Pour iOS, il serait utile de procéder comme suit (que vous ayez un Mac ou non):

1. Créez un compte Apple ID https://appleid.apple.com/#!&page=signin
2. (Si vous n'avez pas de Mac, les étapes suivantes devront être effectuées le jour de la compétition) Accédez à https://ionicframework.com/blog/deploying-to-a-device-without-an-apple-developer-account/ pour configurer votre profil d'approvisionnement. Plus précisément, suivez les étapes décrites dans les sections suivantes: "Getting Set Up" qui vous permettra de vous connecter à XCode, "Code Signing in XCode" dans la section XCode 8+. Cela vous permettra de créer le profil d'approvisionnement sur le Mac. Enfin, la section "Trusting the Certificate" expliquera comment autoriser votre appareil iOS à exécuter et déboguer votre application.
3. De plus amples informations sur ce processus sont disponibles à l'URL StackOverflow suivante: https://stackoverflow.com/questions/4952820/test-ios-app-on-device-without-apple-developer-program-or-jailbreak

**Dans le meilleur des cas, vous devriez pouvoir créer et voir le projet de base sur Android et iOS (en supposant que vous avez le matériel). Vous n'avez pas la compé elle-même, mais n'hésitez pas à personnaliser ce projet comme bon vous semble. Il sera similaire à celui du jour de la compétition.**

![alt text](https://i.gyazo.com/4fda71cd14d7c08fc3f35a26de981ec8.png "Composantes à installer")
