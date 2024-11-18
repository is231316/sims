# sims
# Projektname: Dockerisierte Webanwendung mit REST-API, MSSQL und Redis-Integration

## Übersicht
Dieses Projekt zielt darauf ab, eine moderne, skalierbare und containerisierte Lösung unter Verwendung verschiedener Technologien zu entwickeln. Es besteht aus einer Webanwendung, einer Konsolenanwendung, einer RESTful User API, einer MSSQL RDBMS und einer Redis NoSQL-Datenbank, die alle innerhalb von Docker orchestriert werden. Diese Lösung wurde mit .NET 8, C#, Blazor entwickelt und nutzt Docker für eine konsistente Umgebung und Skalierbarkeit.

![Architekturdiagramm des Projekts](path/to/architecture-diagram.png)

## Architekturübersicht

- **Web-App / Konsole**: Benutzerorientierte Anwendung, als Web-Frontend (mit Blazor) (in C# geschrieben).
- **User API (REST API)**: RESTful API-Dienst, entwickelt mit .NET 8 und C#. Er verwaltet die gesamte Kommunikation zwischen Frontend und Datenbanken.
- **RDBMS (MSSQL)**: Relationale Datenbank zur Verwaltung strukturierter Daten, verwaltet über Docker.
- **NoSQL (Redis)**: NoSQL Key-Value Store für das Caching, die Sitzungsverwaltung und andere Hochleistungsanforderungen.
- **Docker**: Containerisierte Lösung für eine einfache Bereitstellung und Skalierung. Docker stellt sicher, dass jeder Teil des Systems in seinem eigenen Container läuft, wodurch Abhängigkeiten reduziert und die Wartbarkeit erhöht werden.

## Funktionen

- **Benutzerverwaltung**: Erstellen, aktualisieren und verwalten von Benutzerkonten mit gehashter Passwortspeicherung unter Verwendung von Redis.
- **Datenspeicherung**: MSSQL für relationale Daten mit klar definierten Schemas. Redis wird für High-Speed-Daten-Caching, Key-Value-Speicherung und Authentifizierung verwendet.
- **Sicherheit**: Passwort-Hashing wird mit SHA-256 durchgeführt, um eine sichere Speicherung der Anmeldeinformationen zu gewährleisten.
- **Blazor-Integration**: Eine moderne, interaktive Web-Erfahrung mithilfe des Blazor-Frameworks.
- **Dockerisierte Umgebung**: Alle Dienste laufen innerhalb von Docker-Containern, um die Entwicklung und Bereitstellung zu optimieren.

## Voraussetzungen

- **Docker**: Stellen Sie sicher, dass Docker auf Ihrem System installiert ist. Dieses Projekt verwendet Docker Compose für die Orchestrierung.
- **.NET 8 SDK**: Installieren Sie die neueste Version des .NET 8 SDK.
- **Visual Studio oder VS Code**: Bevorzugte IDE für die Entwicklung.

## Installationsanweisungen

1. **Repository klonen**
   ```sh
   git clone https://github.com/yourusername/yourproject.git
   cd yourproject
   ```

2. **Umgebungskonfiguration**
   - Legen Sie eine `.env`-Datei im Root-Verzeichnis des Projekts an, um Umgebungsvariablen zu konfigurieren.
   - Konfigurieren Sie die Verbindungszeichenfolgen für MSSQL und Redis.

3. **Container erstellen und ausführen**
   - Erstellen und starten Sie die Container mithilfe von Docker Compose.
   ```sh
   docker-compose up --build
   ```

4. **Zugriff auf die Dienste**
   - Web-App: [http://localhost:5000](http://localhost:5000)
   - User API: [http://localhost:7287/api/incidents](http://localhost:7287/api/incidents)
   - Redis CLI: Verbinden Sie sich über die Kommandozeile mit der Redis-Instanz:
   ```sh
   docker exec -it <redis-container-name> redis-cli
   ```

## Nutzung

- **Web-App**: Benutzer können über das in Blazor entwickelte Frontend mit der Anwendung interagieren. Die Anwendung ermöglicht das Incident-Tracking und die Benutzerverwaltung.
- **Konsolenanwendung**: Alternative Client-Anwendung, die direkt mit der User API für Backend-Operationen kommuniziert.
- **User API**: Die Kern-Backend-REST-API, die für die Verarbeitung von Anfragen und die Interaktion mit MSSQL und Redis verantwortlich ist.

## Wichtige Endpunkte

- **User API**:
  - `POST /api/incidents`: Erstellt ein neues Incident.
  - `GET /api/incidents`: Ruft alle Incidents ab.
  - `POST /api/users/login`: Authentifiziert Benutzer unter Verwendung von Redis für die Sitzungsverwaltung.

## Docker-Container Übersicht

- **Web-App/Konsolen-Container**: Hostet die Frontend-Webanwendung oder die Konsolen-App.
- **User-API-Container**: Hostet die REST-API-Dienste.
- **MSSQL-Container**: Hostet die relationale Datenbank für strukturierte Daten.
- **Redis-Container**: Hostet die Redis NoSQL-Datenbank für Caching und Authentifizierung.

## Verwendete Technologien

- **.NET 8 / C#**: Backend-Entwicklung und API-Dienste.
- **Blazor**: Frontend-Entwicklung für die Webanwendung.
- **MSSQL**: Relationale Datenbank für persistente Daten.
- **Redis**: NoSQL Key-Value Store für Caching und schnelle Datenabfrage.
- **Docker**: Containerisierung und Orchestrierung.

## Häufige Probleme & Fehlerbehebung

1. **Docker-Netzwerkprobleme**:
   - Stellen Sie sicher, dass das Docker-Netzwerk korrekt konfiguriert ist, um eine Inter-Container-Kommunikation zu ermöglichen.

2. **Redis-Verbindung**:
   - Um die Redis CLI innerhalb des Containers zu öffnen:
   ```sh
   docker exec -it <redis-container-name> redis-cli
   ```

3. **API-Verbindung**:
   - Überprüfen Sie die API-URL in Ihrer Konfiguration und stellen Sie sicher, dass sie mit den freigegebenen Ports des Docker-Containers übereinstimmt.

## Zukünftige Verbesserungen

- **Benutzerauthentifizierung hinzufügen**: Implementieren Sie JWT für bessere Sicherheitspraktiken.
- **CI/CD-Pipeline**: Integration mit GitHub Actions für Continuous Integration und Deployment.
- **Skalierung**: Verwenden Sie Docker Swarm oder Kubernetes, um die Dienste bei Bedarf zu skalieren.

## Beitrag leisten

Wenn Sie einen Beitrag leisten möchten, senden Sie bitte eine Pull-Anfrage. Issues und Feature-Anfragen sind ebenfalls willkommen.

## Lizenz

Dieses Projekt steht unter der MIT-Lizenz - siehe LICENSE-Datei für Details.

## Kontakt

- **Autor**: GÖSLBAUER Monika
- **E-Mail**: is231316@fhstp.ac.at

## Danksagungen

- **Redis und MSSQL Images**: Offizielle Docker Hub Images für Redis und MSSQL.
- **Docker**: Für das Bereitstellen eines fantastischen Containerisierungstools.

