# Exploratorium
## Name der Anwendung
<!-- Bezeichnung entspricht dem Titel der Anwendungauf der Website. Bitte achten Sie auf eine einheitliche Terminologie.-->

Senckenberg Museum Görlitz - Exploratorium

## Inhaltsverzeichnis

<!-- Ermöglichen Sie den LeserInnen einen Schnelleinstieg in die folgenden Kapitel des Readme. Hinweise zur Erstellung eines Inhaltsverzeichnisses finden Sie am Ende des Kapitels.-->

- [Exploratorium](#exploratorium)
  - [1. Name der Anwendung](#1-name-der-anwendung)
  - [2. Inhaltsverzeichnis](#2-inhaltsverzeichnis)
  - [3. Kurzbeschreibung](#3-kurzbeschreibung)
  - [4. Installation](#4-installation)
  - [5. Benutzung](#5-benutzung)
    - [5.1 Besucher](#51-besucher)
    - [5.2 Moderator](#52-moderator)
    - [5.3 Administrator](#53-administrator)
    - [5.4 Systemvoraussetzungen Backend](#54-systemvoraussetzungen-backend)
    - [5.5 Systemvoraussetzungen Frontend](#55-systemvoraussetzungen-frontend)
    - [5.6 Systemvoraussetzungen Netzwerk](#56-systemvoraussetzungen-netzwerk)
  - [6. Beteiligung](#6-beteiligung)
  - [7. Credits](#7-credits)
  - [8.Lizenz / License](#8lizenz--license)

## Kurzbeschreibung

"Exploratorium" ist ein Medienexponat/Installation des Senckenberg Museum Görlitz bestehend aus einem physischen, freistehenden Regal in das sieben 55" Touch-Bildschirme eingelassen sind. An diesen Bildschirmen können Besucher eigenständig und unabhängig voneinander Audiovisuelle Medieninhalte (Bilder, Videos und 3D Modelle) zu den Themen A, B, C entdecken und betrachten. Die Installation versucht dabei dem Besucher einen Überblick und breitgefächertes Verständnis für die Arbeit mit einer wissenschaftlichen Sammlung in all ihren Aspekten zu vermitteln.

Dieses [ANWENDUNGSTYP] ist entstanden im Verbundprojekt _museum4punkt0 – Digitale Strategien für das Museum der Zukunft_, Teilprojekt [NAME_TEILPROJEKT_DE]. Das Projekt museum4punkt0 wird gefördert durch die Beauftragte der Bundesregierung für Kultur und Medien aufgrund eines Beschlusses des Deutschen Bundestages. [Weitere Informationen](www.museum4punkt0.de)

This [APP_TYPE] is part of the project _museum4punkt0 - Digital Strategies for the Museum of the Future_, sub-project [NAME_TEILPROJEKT_EN]. The project _museum4punkt0_ is funded by the Federal Government Commissioner for Culture and the Media in accordance with a resolution issued by the German Bundestag (Parliament of the Federal Republic of Germany). [Further information](www.museum4punkt0.de/en/)

## Installation

Geben Sie BenutzerInnen Informationen zur Installation / zum Aufsetzen der Anwendung und dazu benötigter Hard-/Software.

## Benutzung

<!-- Beschreiben Sie die Benutzung der Anwendung nach der Installation. Fügen Sie bestenfalls Screenshots ein, um die Handhabung zu illustrieren. -->

### Besucher

Die vordergründige Benutzung der Applikation ist selbsterklärend und wurde für einen ungestüzten, autonomen Betrieb entworfen. Dieser Modus startet automatisch wenn die Anwendung lokal auf einem Rechner installiert wird.

> **Wichtiger Hinweis:** Aus rechtlichen Gründen können keine Medieninhalte zur Anwendung mitgeliefert werden und eine solche Installation ist nicht lauffähig.

### Moderator

Neben dem autonomen Besucher-Modus verfügt die Applikation über einen versteckten Moderator-Modus mit dem andere Instanzen der Applikation ferngesteuert werden können. Um diesen nutzen zu können muss die Applikation in einem Netzwerk und einer bestimmten Konfiguration gestartet werden. [Setup Details](#53-administrator)

Danach befinden sich alle Stationen in ihrer konfigurierten Rolle (SOLO oder OBSERVER). Wird an einer der nun vernetzten Stationen die CONTROLLER-Rolle aktiv, dann synchronisieren sich alle verbundenen OBSERVER-Stationen mit dem Zustand der CONTROLLER Station. Es wird stets der letzten Station welche die CONTROLLER-Rolle anfordert diese auch zugewiesen, wobei die vorige CONTROLLER-Station diese Rolle verliert und in die SOLO-Rolle zurück kehrt.

#### Bildschrimausrichtung

 Die Applikation reagiert dynamisch auf Format und Auflösung des angeschlossenen Displays. Dabei sind die CONTROLLER- und SOLO-Rolle für einen Betrieb im 9:16 Format vorgesehen, die OBSERVER-Rolle ist hingegen primär für ein 16:9 Format geeignet.

#### Moderator Modus Aktivieren

 Ein Umschalten zwischen SOLO- und CONTROLLER-Rolle ist über einen 3-fach-Klick bzw. -Tap in der oberen rechen Bildschirm Ecke möglich. Während die CONTROLLER-Rolle aktiv ist erscheint in der Ecke ein "M". Die CONTROLLER-Rolle kann mit einem weiteren 3-fach-Klick wieder abgegeben werden.

### Administrator

Die Anwendung selbst enthält keine Medieninhalte. Diese werden dynamisch beim Start der Anwendung via REST API aus dem Datenbank-Backend geladen und lokal zwischengespeichert. Das Backend kann im lokalen Netzwerk oder auf einem Cloud-Server eingerichtet werden. Falls aus irgendwelchen Gründen keine Verbindung zum Backend verfügbar ist, begibt sich die Anwendung automatisch in einen Offline-Modus und nutzt die zuvor zwischengespeicherten Inhalte. Die Inhalte im Datenbank Backend können mithilfe der zugehörigen Web-Applikation verwaltet werden. Der Zwischenspeicher aktualisiert sich automatisch beim nächsten Start der Anwendung sofern das Backend erreichbar ist.

Sofern ein vollständiger Zwischenspeicher bestehend aus API-Cache und Medien-Files verfügbar ist, kann die Anwendung vollständig ohne Zugang zu einem Backend in Betrieb genommen werden.

Folgende Struktur findet sich in `%APPDATA%/LocalLow/mbox/Exploratorium/` nachdem die App einmal erfolgreich gestartet wurde. Ist ein korrekt konfiguriertes Backend verfügbar wird diese Struktur automatisch erzeugt.

```txt
./cache/directus.cache   # Aktuelle Version des Directus API Cache
./cache/directus.cache.* # Alte Versionen des Directus API Cache
./directus/*             # Medien Inhalte
./logs/*                 # Protokoll der letzten Verbindungen zum Backend
./config.json            # Konfiguration der App
./Player.log             # Protokoll der aktuellen App Laufzeit-Session
./Player-prev.log        # Protokoll der vorigen App Laufzeit-Session
``` 

Mit angeschlossener Tastatur sind in der App folgende Funktionen verfügbar:

- `F1` zeigt ein Hilfe-Menü mit verfügbaren Tastaturbefehlen
- `F2` zeigt ein Einstellungs-Menü mit dem die App konfiguriert werden kann, insbesondere der Backend-Zugriff und die Verbindung mit anderen Stationen im Netzwerk sind hier einstellbar. Zudem können von hieraus auch die verschiedenen Netzwerk Modi (Client/Server/Host) sowie der Zwischenspeicher der Backend-Inhalte verwaltet werden.
- `F3` zeigt ein Menü zur Steuerung der aktuellen Netzwerk-Rolle der App und eine Übersicht der anderen Stationen die verbunden sind.
- `F4` zeigt einen Log-Viewer mit dem eine erste Fehlerdiagnose vorgenommen werden kann.
- `F5` zeigt einen Performance Monitor
- `F10` speichert einen Screenshot des aktuellen Zustands der App
- `Alt+F4` beendet die App

Beim ersten Start der Anwendung wird eine `config.json` Datei angelegt welche die Standardkonfiguration für lokale SOLO-Stationen enthält. Diese Datei kann mittels Einstellungs-Menü (`F2`) in der Anwendung selbst, oder von Hand editiert werden.

Das Backend besteht aus mehreren Teilen: Zunächst aus einer PostgreSQL Datenbank für alle strukturierte Inhalte, einer Directus basierten REST-API um den Datenbank-Zugriff zu abstrahieren und einer Directus basierten Admin WebApp zur Anwendungsspezifischen Verwaltung der Datenbank-Inhalte. Medieninhalte (Videos, Bilder und Modelle) werden als einfache Dateien vorgehalten und von der Datenbank referenziert. Alle Teile des Backend können als Container auf jedem beliebigen OCI kompatiblen Host eingesetzt werden. Alle notwendigen Konfigurationsparameter sind im README des Container Stacks erläutert. [Link zum Container Repo](http://repos.m-box.de), [Link zur CMS Admin Doku](http://repos.m-box.de)

### Frontend

Die Stationen benötigen Windows 10 [WIN_VERSION] sind optimal jeweils ein [PC SPEC] mit [MONITOR SPEC] vorgesehen.

- Windows 10
- 2+ CPU Cores
- 16 GB RAM
- 100 GB HDD
- [GPU Spec]
- [Touchscreen Spec] (optional)
- [Audio Spec] (optional)
- [Mouse]
- [Keyboard]

### Backend

Für das Backend ist ein beliebiger Docker-fähiger Host notwendig. Die Leistungsfähigkeit hängt vom gewählten Host ab, kann jedoch recht sparsam gewählt werden.

- OCI Engine
- 2+ CPU Cores
- 1000 MBit/s NIC
- 100 GB HDD

### Netzwerk / Betriebskonzept

Zur Vernetzung von bis zu 7 Stationen inklusive Backend empfiehlt sich [NETZWERK SPEC].

- 1000 MBit/s

Auch Anforderungenan Geräte / Ausstattung bzw. Systemvoraussetzungen für den Betrieb sollten hier genannt sein. Falls Ihre Anwendung über ein Backend verfügt, sollte Ihnen ein Benutzerhandbuch für die Backend-Nutzung vorliegen. Stellen Sie dieses bitte auch zur Verfügung,indem Sie es (als PDF/A-3) im Github-Repositoriumhochladen und in der Readme-Datei darauf verlinken. Existiert zudem ein Betriebskonzept, sollten Sie dieses von hier aus per Link zugänglich machen.

## Beteiligung

Eine Fortlaufende Entwicklung der Anwendung ist nicht vorgesehen.

<!-- Geben Sie hier an, ob und in welcher Art man sich an Ihrer Programmierung beteiligen kann. Detailinformationen werden in einer separaten Datei angelegt. Weitere Hinweise hierzu finden Sie unterhttps://help.github.com/en/articles/setting-guidelines-for-repository-contributors-->

## Credits

X

### Auftraggeber

- [SKBG]
- m-box Bewegtbild GmbH

### Autor und Rechteinhaber

Gerold Schneider, 2022

<!--
AuftraggeberInnen/RechteinhaberInnen(Name Ihrer Institution)UrheberInnen(Namen der beteiligten EntwicklerInnen oder Firma)
Die  AutorInnen  des  Codes  bzw.  zugehörige  Agenturen/Firmen/Institutionen  können  hier verlinkt sein(eventuellRechteangabe nach dem Schema: Institution / UrheberIn, Jahr).
-->

## Lizenz

Copyright 2022 Gerold Schneider

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

<!-- Bitte fügen Sie ferner eine Liste der Lizenzen für wiederverwendete Programmteile Dritter der Dokumentation hinzu.-->

### Proprietäre Drittanbieter Software

- [Directus Connect](https://m-box.de)
- [Unity](https://unity.com/)
- [AVPro Video](https://renderheads.com/products/avpro-video/)
- [Odin Inspector](https://odininspector.com/)
- [Piglet](https://assetstore.unity.com/packages/tools/utilities/piglet-gltf-importer-173425)
- [Shapes](https://assetstore.unity.com/packages/tools/particles-effects/shapes-173167)
- [DOTween Pro](http://dotween.demigiant.com/pro.php)

### Drittanbieter Lizenzen

- Directus [GNU GENERAL PUBLIC LICENSE](https://github.com/directus/directus/blob/main/license)
  - run `npx license-checker --summary`
- Directus-Connect / Copyright 2020-2022 Gerold Schneider, All Rights Reserved (proprietär)
- DOTween [DOTween Pro License](http://dotween.demigiant.com/license.php) (proprietär)
- OdinInspector [ODIN INSPECTOR PERSONAL END ­USER LICENSE AGREEMENT](https://odininspector.com/eula) (proprietär)
- Unity [Unity Terms of Service](https://unity3d.com/legal/terms-of-service) (proprietär)
- Parrel Sync [MIT License](https://github.com/VeriorPies/ParrelSync/blob/master/LICENSE.md)
- Unity Atoms [MIT License](https://github.com/unity-atoms/unity-atoms/blob/master/LICENSE.md)
- Stateless [Apache License, Version 2.0](https://github.com/dotnet-state-machine/stateless/blob/dev/LICENSE)
- MessagePack [MIT License](https://github.com/neuecc/MessagePack-CSharp/blob/master/LICENSE)
- Serilog [Apache License, Version 2.0](https://github.com/serilog/serilog/blob/dev/LICENSE)
- HTML Agility Pack [MIT License](https://github.com/zzzprojects/html-agility-pack/blob/master/LICENSE)
- NHyphenator [Apache License, Version 2.0](https://github.com/alkozko/NHyphenator/blob/master/LICENSE)
- Hyphenation Patterns [The LATEX Project Public License](https://ctan.org/license/lppl1)
- Stubble [MIT License](https://github.com/StubbleOrg/Stubble/blob/master/licence.md)
- Markdig [BSD 2](https://github.com/xoofx/markdig/blob/master/license.txt)
- Fingers Gestures [Fingers License](https://github.com/DigitalRuby/FingersGestures/blob/master/LICENSE.txt)
- Graphy [MIT License](https://github.com/Tayx94/graphy/blob/master/LICENSE)
- CommandLine for Unity [MIT License](https://github.com/pschraut/UnityCommandLine/blob/master/LICENSE.md)
- Piglet: glTF Importer [Asset Store Terms of Service and EULA](https://unity3d.com/legal/as_terms) (proprietär)
- Shapes [Asset Store Terms of Service and EULA](https://unity3d.com/legal/as_terms) (proprietär)
- AVPro Video [Asset Store Terms of Service and EULA](https://unity3d.com/legal/as_terms) (proprietär)
- Google ExoPlayer [Apache License 2.0](https://github.com/google/ExoPlayer)
- Libsamplerate [BSD 2-Clause "Simplified" License](https://github.com/libsndfile/libsamplerate)
- Vidvox Hap [BSD 2-Clause "Simplified" License](https://github.com/Vidvox/hap)
- HapInAVFoundation [More Info](https://github.com/Vidvox/hap-in-avfoundation)
- Squish [MIT License](https://licenses.nuget.org/MIT)
- Google Snappy [BSD-type custom license](https://github.com/google/snappy)
- Facebook Audio 360 [More Info](https://facebook360.fb.com/spatial-workstation/)
- GDCL-MPEG4 [More Info](https://www.gdcl.co.uk/downloads.htm)
- .NET System.Buffers [MIT License](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)
- .NET System.Memory [MIT License](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)
- .NET System.Numerics.Vectors [MIT License](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)
- .NET System.CodeDom [MIT License](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)
- .NET System.Collections.Immutable [MIT License](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)
- .NET System.Reactive [MIT License](https://licenses.nuget.org/MIT)
- .NET System.Reactive.Linq [MIT License](https://licenses.nuget.org/MIT)
- .NET System.Runtime.CompilerServices.Unsafe [MIT License](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)
- .NET System.Threading [MICROSOFT SOFTWARE LICENSE TERMS](https://dotnet.microsoft.com/en-us/dotnet_library_license.htm)
- .NET System.Threading.Tasks.Extensions [MIT License](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)
- .NET System.IO.Compression.ZipFile [MICROSOFT SOFTWARE LICENSE TERMS](https://dotnet.microsoft.com/en-us/dotnet_library_license.htm)