# Klassbeskrivning



## GameBoard

| Variabler                                             | Beskrivning                                                  |
| ----------------------------------------------------- | ------------------------------------------------------------ |
| public IList<BoardCoordinate> CoordinateOuterPosition | //det gemensama spelarbrädet                                 |
| public IList<GamePlayer> GamePlayers                  | //lista där de GamePlayers som ingår i sessionen läggs in.   |
| public int GamePlayerAmnt                             | //antal spelare som ingår i sessionen                        |
| public string SessionName                             | //sessionsnamn                                               |
| public bool NewGame                                   | //om det är en ny session som skapas eller om man laddat ett sparat spel |
| public Dice dice                                      | //instans av klassen Dice                                    |
| private string winner                                 | //sätts då någon vinner spelomgången                         |
| private int saveOrSkip                                | //returvärde för menyval spara eller skippa att spara        |
| private ConsoleColor playerTextColor                  | //hjälper till att skriva text i konsolen i samma färg som spelaren |
| private IGameSession gs                               | //tar emot parametern i klassens konstruktor                 |
| private GameData gameData                             | //instans av GameData som innehåller databasrelaterade metoder att använda i programmet |

| Metoder                                                | Beskrivning                                                  |
| ------------------------------------------------------ | ------------------------------------------------------------ |
| public void GameLoop()                                 | //här sker hela spelomgången                                 |
| private void SaveGame()                                | //spara spel                                                 |
| private void SaveWinner()                              | //spara vinnaren                                             |
| private void DisplayWinner()                           | //text på konsolen som visar vem som vann                    |
| private void MovePieceOnDiceResult()                   | //samlingsmetod som flyttar spelpjäs beroende på tärningsslag via olika parametrar. Innehåller även flera andra metoder relaterade till att positionera spelpjäs. |
| private void MovePiece()                               | //samlingsmetod via parmetrar som flyttar spelpjäsens position. |
| private IList<string> CreatePieceBtnOptions()          | //meny som sätts med parametrar som visar tillgängliga spelpjäser att välja mellan, antingen inkl. de som finns i Nest, eller exklusive |
| private IList<string> CreatePieceButtonOptionsInNest() | //meny som sätts med parametrar som visar tillgängliga spelpjäser att välja mellan, endast de som finns i Nest. |
| private int GetPlayerIndex()                           | //returnerar index för en spelare via parameter klass        |
| private int GetPieceIndex()                            | //returnerar index för en spelpjäs via parametrar            |
| private GamePiece GetPieceByID()                       | //returnerar en GamePiece med id X via parametrar            |
| private int GetGlobalPosition()                        | //returnerar global positon av en spelpjäs på gemensamma spelbrädet, via parametrar |
| private int GetPreviousPieceLocalPosition()            | //returnerar en spelpjäs föregående position (föregående tärningsslag) via parametrar |
| private int GetNewLocalPiecePosition()                 | //returnerar en spelares nya lokala position (efter tärningsslag) via parmetrar |
| private void MoveLocalPiece()                          | //flytta spelpjäsen på lokalt spelbräde via parametrar       |
| private void MoveGlobalPiece()                         | //flytta spelpjäsen på gemensamt spelbräde via parametrar    |
| private int CheckCollision()                           | //kontrollerar och sköter kollission mellan olika spelpjäser via olika parametrar |
| public void InitializeGame()                           | //samlingsmetod för initialiserande data när en ny spelsession skapats och GameBoard skall skapas upp |
| private void InitializeBoardCoordinates()              | //skapar upp det gemensamma spelbrädet: IList<BoardCoordinate> CoordinateOuterPosition |
| private int DecidePlayerStart()                        | //bestämmer vilken spelare som kastar högst tärningsslag och får börja via parameter. Returnerar int (id) på spelaren |
| public IList<GamePlayer> SetPlayOrder()                | //tar bla. in parameter (returvärde) från DecidePlayerStart() för att ta reda på spelarens färg. Sätter sedan medsols spelordning utefter vilken färg spelaren som får börja spela, har. |
| public int SetColorStartPositon()                      | //sätter positioner på olika spelarfärgers statpositioner GamePlayers.GlobalStartPosition på det gemensamma spelarbrädet |

