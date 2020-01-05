Imports System.IO

Public Class Form1
    Inherits Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem4, Me.MenuItem9, Me.MenuItem18, Me.MenuItem12})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem8, Me.MenuItem3})
        Me.MenuItem1.Text = "Game"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "New"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "High Scores..."
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Quit"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem7})
        Me.MenuItem4.Text = "Arena"
        '
        'MenuItem5
        '
        Me.MenuItem5.Checked = True
        Me.MenuItem5.Index = 0
        Me.MenuItem5.RadioCheck = True
        Me.MenuItem5.Text = "80x24 (Classic)"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.RadioCheck = True
        Me.MenuItem6.Text = "40x12"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.RadioCheck = True
        Me.MenuItem7.Text = "Custom..."
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem11})
        Me.MenuItem9.Text = "Grid"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.RadioCheck = True
        Me.MenuItem10.Text = "On"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.RadioCheck = True
        Me.MenuItem11.Text = "Off (Classic)"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 3
        Me.MenuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem20})
        Me.MenuItem18.Text = "Sounds"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        Me.MenuItem19.RadioCheck = True
        Me.MenuItem19.Text = "On"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.RadioCheck = True
        Me.MenuItem20.Text = "Off"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 4
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem14})
        Me.MenuItem12.Text = "Help"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Text = "Instructions"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 1
        Me.MenuItem15.Text = "Keys"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Text = "Mouse"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 3
        Me.MenuItem17.Text = "Scoring"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 4
        Me.MenuItem14.Text = "About"
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 670)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(1264, 22)
        Me.StatusBar1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1264, 670)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(3, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1258, 649)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1264, 692)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "WinBots"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Enum Directions
        ' all possible mouse directions
        UP = 0
        DOWN = 1
        LEFT = 2
        RIGHT = 3
        UPLEFT = 4
        UPRIGHT = 5
        DOWNLEFT = 6
        DOWNRIGHT = 7
        ZAP = 8
    End Enum

    Private Enum Grid
        ' all possible grid position contents
        EMPTY = 0 ' enumeration for empty grid position
        ENEMY = 1 ' enumeration for enemy in grid position
        PLAYER = 2 ' enumeration for player in grid position
        TRASH = 3 ' pile of rubble
        DEATH = 4 ' dead player
    End Enum

    Private Enum Action
        ' all possible actions
        STILL = 0 ' no action
        SCREW = 1 ' apply screwdriver
        TEL = 2 ' teleport
        WAIT = 3 ' wait
    End Enum

    Structure ScoreRec
        ' record for high score list
        Dim Name As String
        Dim Score As Integer
        Dim Level, Screwdrivers As Byte
        Dim Today As DateTime
    End Structure

    Const THICKNESS As Integer = 2 ' thickness of each grid line
    Const gMARGIN As Integer = 1 ' gMARGIN within each grid position to draw graphic
    Const mUP As Integer = -1 ' upward change to Y direction in grid reference
    Const mDOWN As Integer = 1 ' downward change to Y direction in grid reference
    Const mLEFT As Integer = -1 ' leftward change to X direction in grid reference
    Const mRIGHT As Integer = 1 ' rightward change to X direction in grid reference
    Const MAXSCORES As Integer = 10 ' total number of scores in high score file
    Const SND_ASYNC As Integer = &H1 ' play sounds asynchronously
    Const SND_FILENAME As Integer = &H20000 ' sound is in file name

    Friend Shared Columns As Byte = 80 ' original grid size from text-based screen days
    Friend Shared Rows As Byte = 24 ' original grid size from text-based screen days, line 25 displayed the status info.
    Dim HighScores(MAXSCORES - 1) As ScoreRec ' high score list
    Dim pname As String ' name of player
    Dim dead As Boolean = True ' state of player
    Dim enemies As Integer ' number of enemies
    Dim level As Byte ' player starting level
    Dim score As Integer ' score 1 point per dalek death, 2 points per dalek death by screwdriver, 3 points during a 'wait' action
    Dim screwdrivers As Byte ' number of screwdrivers remaining.
    Dim pcol, prow As Byte ' position of player in grid
    Dim wait As Boolean ' true when waiting
    Dim gridwidth As Single ' width of each column in grid
    Dim gridheight As Single ' height of each column in grid
    Dim osi As Image ' off-screen image
    Dim osg As Graphics ' off-screen graphics
    Dim g As Graphics ' on-screen graphics
    Dim PlayGrid(,) As Byte  ' array to record where everything is
    Dim MoveGrid(,) As Byte ' working array during each move
    Dim msUP As New MemoryStream(My.Resources.up)
    Dim cUP As New Cursor(msUP) ' cursor for up arrow
    Dim msDOWN As New MemoryStream(My.Resources.down)
    Dim cDOWN As New Cursor(msDOWN) ' cursor for down arrow
    Dim msLEFT As New MemoryStream(My.Resources.left)
    Dim cLEFT As New Cursor(msLEFT) ' cursor for left arrow
    Dim msRIGHT As New MemoryStream(My.Resources.right)
    Dim cRIGHT As New Cursor(msRIGHT) ' cursor for right arrow
    Dim msUPLEFT As New MemoryStream(My.Resources.upleft)
    Dim cUPLEFT As New Cursor(msUPLEFT) ' cursor for up and left arrow
    Dim msUPRIGHT As New MemoryStream(My.Resources.upright)
    Dim cUPRIGHT As New Cursor(msUPRIGHT) ' cursor for up and right arrow
    Dim msDOWNLEFT As New MemoryStream(My.Resources.downleft)
    Dim cDOWNLEFT As New Cursor(msDOWNLEFT) ' cursor for down and left arrow
    Dim msDOWNRIGHT As New MemoryStream(My.Resources.downright)
    Dim cDOWNRIGHT As New Cursor(msDOWNRIGHT) ' cursor for down and right arrow
    Dim msZAP As New MemoryStream(My.Resources.zap)
    Dim cZAP As New Cursor(msZAP) ' cursor for teleport and screwdriver
    Dim dir As Directions ' records which direction to move based on the mouse position
    Dim red As Byte = Rnd() * 255 ' red component of colour
    Dim green As Byte = Rnd() * 255 ' green component of colour
    Dim blue As Byte = Rnd() * 255 ' blue component of colour
    Dim alpha As Byte = 255 ' alpha component of colour
    Dim gridlines As Boolean = False ' true if grid displayed
    Dim sound As Boolean = True ' true if sound allowed
    Dim moving As Boolean = False ' true if processing a move
    Dim p As New Pen(Color.FromArgb(alpha, red, green, blue), THICKNESS) ' pen to draw the grid lines

    Private Sub blank()
        ' erases the off-screen image
        osg.Clear(Color.White)
    End Sub

    Private Sub reveal()
        ' paints the off-screen image on-screen
        g.DrawImage(osi, 0, 0)
    End Sub

    Private Sub DrawGrid(ByVal override As Boolean)
        ' display grid and enemy positions
        Dim x, y As Single ' positions of grid lines in arena
        Dim row, col As Byte ' positions of entities in arena
        Dim dalek As Image = My.Resources.dalek ' enemy graphic
        Dim drwho As Image = My.Resources.drwho ' player graphic
        Dim trash As Image = My.Resources.pile ' trash graphic
        Dim skull As Image = My.Resources.skull ' skull graphic
        blank() ' erase arena
        If gridlines Or override Then ' override when showing player the grid size in arena
            ' Draw the vertical lines in the grid:
            For x = 0 To Me.PictureBox1.Width Step Me.PictureBox1.Width / Columns
                osg.DrawLine(p, x, 0, x, Me.PictureBox1.Height)
            Next
            ' Draw the horizontal lines in the grid:
            For y = 0 To Me.PictureBox1.Height Step Me.PictureBox1.Height / Rows
                osg.DrawLine(p, 0, y, Me.PictureBox1.Width, y)
            Next
        End If
        ' Draw the player and enemies:
        For col = 0 To Columns - 1
            For row = 0 To Rows - 1
                If PlayGrid(col, row) = Grid.ENEMY Then
                    osg.DrawImage(dalek, col * gridwidth + gMARGIN, row * gridheight + gMARGIN, gridwidth - gMARGIN * 2, gridheight - gMARGIN * 2)
                ElseIf PlayGrid(col, row) = Grid.PLAYER Then
                    osg.DrawImage(drwho, col * gridwidth + gMARGIN, row * gridheight + gMARGIN, gridwidth - gMARGIN * 2, gridheight - gMARGIN * 2)
                ElseIf PlayGrid(col, row) = Grid.TRASH Then
                    osg.DrawImage(trash, col * gridwidth + gMARGIN, row * gridheight + gMARGIN, gridwidth - gMARGIN * 2, gridheight - gMARGIN * 2)
                ElseIf PlayGrid(col, row) = Grid.DEATH Then
                    osg.DrawImage(skull, col * gridwidth + gMARGIN, row * gridheight + gMARGIN, gridwidth - gMARGIN * 2, gridheight - gMARGIN * 2)
                End If
            Next
        Next
        reveal() ' show arena
    End Sub

    Private Sub DisplayStatus()
        ' Display the level, score and number of remaining screwdrivers in the status bar
        Me.StatusBar1.Text = "Level: " + level.ToString + vbTab + "Score: " + score.ToString + vbTab + "Screwdrivers: " + screwdrivers.ToString
    End Sub

    Private Sub DisplayLevel()
        ' Render the grid and status bar for a new game
        DisplayStatus() ' update the statusbar
        DrawGrid(False) ' render grid and entity positions
    End Sub

    Private Sub SetPosition(ByVal entity As Integer)
        ' place entity (enemy or player) in the grid
        Dim placed As Boolean = False ' true if successfully placed in grid
        Dim col, row As Byte ' random position in grid
        Do
            ' repeat until we have placed the entity successfully
            col = Int(Rnd() * Columns)
            row = Int(Rnd() * Rows)
            ' now check if random position is valid
            If PlayGrid(col, row) = Grid.EMPTY Then ' valid
                PlayGrid(col, row) = entity ' place entity at position
                placed = True ' declare successfully placed
                If entity = Grid.PLAYER Then
                    ' remember player position
                    pcol = col
                    prow = row
                End If
            End If
        Loop Until placed
    End Sub

    Private Sub InitialiseGrid()
        ' place player and enemies in their starting positions in the grid
        Dim d As Byte ' iterate through enemy positions
        For d = 1 To enemies
            SetPosition(Grid.ENEMY)
        Next
        SetPosition(Grid.PLAYER)
    End Sub

    Private Sub ResetGrid(ByVal thisgrid As Byte(,))
        Dim col, row As Byte ' iterate through grid
        For col = 0 To Columns - 1
            For row = 0 To Rows - 1
                thisgrid(col, row) = Grid.EMPTY
            Next
        Next
    End Sub

    Private Sub newgame()
        ' starts a new game
        gridwidth = Me.PictureBox1.Width / Columns ' width of each column in grid
        gridheight = Me.PictureBox1.Height / Rows ' height of each column in grid
        dead = False ' set player status
        wait = False ' set wait status
        moving = False ' accept player moves
        level = 1 ' first level
        score = 0 ' start from scratch
        screwdrivers = 1 ' start with 1 screwdriver
        enemies = 5 ' set number of enemies relevant to the level
        ResetGrid(PlayGrid) ' reset playing grid
        ResetGrid(MoveGrid) ' reset working grid
        InitialiseGrid() ' set positions of player and enemies
        DisplayLevel() ' draw the grid, daleks and player position for new level
        Me.PictureBox1.Enabled = True ' enable the grid for play
        Me.MenuItem4.Enabled = False ' disable grid selection menu
        Me.MenuItem9.Enabled = False ' disable Grid menu
        If sound Then
            ' random sound to start the game with
            'PlaySound("newgame" + Int(Rnd() * 12).ToString + ".wav", Nothing, SND_FILENAME Or SND_ASYNC)
            My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject("newgame" + Int(Rnd() * 12).ToString), AudioPlayMode.Background)
        End If
    End Sub

    Private Sub ApplyTeleport()
        ' Teleport is ALWAYS safe!  However although the player move might be to teleport safely ie not on top of an enemy,
        ' the enemy then has it's move towards the player and if an enemy is adjacent to the teleported player, the enemy's move
        ' will destroy the player.
        Dim teleported As Boolean = False ' true if successfully teleported
        Dim tardis As Image = My.Resources.tardis ' tardis graphic
        Dim brush As New SolidBrush(Color.White) ' brush to draw the grid lines
        If sound Then
            ' random sound to start the game with
            My.Computer.Audio.Play(My.Resources.tardis1, AudioPlayMode.Background)
        End If
        g.DrawImage(tardis, pcol * gridwidth + gMARGIN, prow * gridheight + gMARGIN, gridwidth - gMARGIN * 2, gridheight - gMARGIN * 2) ' enter the tardis
        Sleep(2000) ' delay
        g.FillRectangle(brush, pcol * gridwidth + gMARGIN * 2, prow * gridheight + gMARGIN * 2, gridwidth - gMARGIN * 4, gridheight - gMARGIN * 4 + 1)
        Do
            pcol = Int(Rnd() * Columns) ' choose random column to teleport to
            prow = Int(Rnd() * Rows) ' choose random row to teleport to
            If PlayGrid(pcol, prow) = Grid.EMPTY Then
                teleported = True
            End If
        Loop Until teleported
        g.DrawImage(tardis, pcol * gridwidth + gMARGIN, prow * gridheight + gMARGIN, gridwidth - gMARGIN * 2, gridheight - gMARGIN * 2) ' tardis reappears
        Sleep(2000) ' delay
        MoveGrid(pcol, prow) = Grid.PLAYER ' set new player position in working grid
    End Sub

    Private Function ApplyMove(ByVal deltarow As Integer, ByVal deltacol As Integer) As Boolean
        ' Process the player move
        Dim newcol, newrow As Byte
        If pcol + deltacol < 0 Then ' went beyond left limit of grid
            Return False ' declare invalid move
        ElseIf pcol + deltacol = Columns Then ' went beyond right limit of grid
            Return False ' declare invalid move
        Else ' moved within grid
            newcol = pcol + deltacol
        End If
        If prow + deltarow < 0 Then ' went beyond upper limit of grid
            Return False ' declare invalid move
        ElseIf prow + deltarow = Rows Then ' went beyond lower limit of grid
            Return False ' declare invalid move
        Else ' moved within grid
            newrow = prow + deltarow
        End If
        ' valid move so record new player position
        pcol = newcol
        prow = newrow
        If PlayGrid(newcol, newrow) = Grid.ENEMY Or PlayGrid(newcol, newrow) = Grid.TRASH Then
            ' moved onto adjacent enemy or rubble, no points for suicide!
            MoveGrid(pcol, prow) = Grid.DEATH ' display death graphic
            enemies = enemies - 1 ' well, there's one less enemy not that it really matters as the game is about to end
            dead = True ' this will end the game
        Else
            ' moved into vacant grid position
            MoveGrid(pcol, prow) = Grid.PLAYER
        End If
        Return True ' declare valid move
    End Function

    Private Function MoveEnemies() As Boolean
        Dim row, col As Byte ' iterate through rows and columns
        Dim ecol, erow As Byte ' new enemy position
        MoveEnemies = False ' no collision noise by default
        For col = 0 To Columns - 1
            For row = 0 To Rows - 1
                If PlayGrid(col, row) = Grid.ENEMY Then
                    ecol = IIf(pcol < col, col - 1, IIf(pcol > col, col + 1, col)) ' move enemy towards player column
                    erow = IIf(prow < row, row - 1, IIf(prow > row, row + 1, row)) ' move enemy towards player row
                    ' now that we have the new enemy position, have we collided with anything?
                    Select Case MoveGrid(ecol, erow)
                        Case Grid.ENEMY
                            ' collided with another enemy
                            MoveGrid(ecol, erow) = Grid.TRASH
                            enemies = enemies - 2
                            MoveEnemies = True ' make collision noise
                            If Not dead Then ' add the two destroyed enemies to score
                                score = IIf(wait, score + 6, score + 2) ' if waiting, score tripled
                            End If
                        Case Grid.TRASH
                            ' collided with rubble
                            enemies = enemies - 1
                            MoveEnemies = True ' make collision noise
                            If Not dead Then
                                score = IIf(wait, score + 3, score + 1) ' if waiting, score tripled
                            End If
                        Case Grid.PLAYER
                            ' collided with player
                            MoveGrid(ecol, erow) = Grid.DEATH ' display death graphic
                            enemies = enemies - 1 ' decrease number of enemies
                            dead = True ' end the game
                        Case Grid.EMPTY
                            ' successful move
                            MoveGrid(ecol, erow) = Grid.ENEMY
                    End Select
                End If
            Next
        Next
    End Function

    Private Sub KeepTrash()
        ' remember where all piles of trash are
        Dim col, row As Byte
        For col = 0 To Columns - 1
            For row = 0 To Rows - 1
                If PlayGrid(col, row) = Grid.TRASH Then
                    MoveGrid(col, row) = Grid.TRASH
                End If
            Next
        Next
    End Sub

    Private Sub KeepEnemies()
        ' remember where all enemies are
        Dim col, row As Byte
        For col = 0 To Columns - 1
            For row = 0 To Rows - 1
                If PlayGrid(col, row) = Grid.ENEMY Then
                    MoveGrid(col, row) = Grid.ENEMY
                End If
            Next
        Next
    End Sub

    Private Sub ArrayCopy()
        ' simply copies one 2-dimensional array to another
        Dim col, row As Byte
        For col = 0 To Columns - 1
            For row = 0 To Rows - 1
                PlayGrid(col, row) = MoveGrid(col, row)
            Next
        Next
    End Sub

    Public Sub Sleep(ByVal delay As Integer)
        ' pauses the specified number of milliseconds
        Dim Start, Finish As Double
        Start = DateAndTime.Timer
        Finish = Start + delay / 1000
        Do While DateAndTime.Timer < Finish
            Application.DoEvents()
        Loop
    End Sub

    Private Sub DrawScrew(ByVal col As Byte, ByVal row As Byte)
        ' Render the screwdriver effects
        Dim x, y, w, h As Single
        Dim r, numrects As Integer
        Dim screwpen As New Pen(Color.Orange, THICKNESS) ' pen to draw the rectangles
        x = CSng(col) * gridwidth + gMARGIN * 2 ' left bound of rectangle
        y = CSng(row) * gridheight + gMARGIN * 2 ' top bound of rectangle
        w = gridwidth - gMARGIN * 4 ' width of rectangle
        h = gridheight - gMARGIN * 4 ' height of rectangle
        ' aspect ratio determines number of rectangles to draw
        If gridwidth > gridheight Then
            numrects = gridheight / 2
        Else
            numrects = gridwidth / 2
        End If
        For r = 0 To numrects ' iterate through rectangle sizes
            x = x + 1
            y = y + 1
            w = w - 2
            h = h - 2
            Sleep(10) ' delay
            g.DrawRectangle(screwpen, x, y, w, h)
        Next
        screwpen.Color = Color.White ' now erase the rectangles
        For r = numrects To 0 Step -1 ' iterate through rectangle sizes
            x = x - 1
            y = y - 1
            w = w + 2
            h = h + 2
            Sleep(10) ' delay
            g.DrawRectangle(screwpen, x, y, w, h)
        Next
    End Sub

    Private Sub ScrewEnemy(ByVal col As Byte, ByVal row As Byte)
        ' Apply screwdriver to all adjacent positions.
        If sound Then
            ' screwdriver sound effect
            My.Computer.Audio.Play(My.Resources.screw, AudioPlayMode.Background)
        End If
        DrawScrew(col, row) ' animate the screwdriver
        If PlayGrid(col, row) = Grid.ENEMY Then
            PlayGrid(col, row) = Grid.EMPTY ' so we don't move it later
            MoveGrid(col, row) = Grid.EMPTY ' so it is gone after this move ends
            enemies = enemies - 1 ' decrease number of enemies
            score = score + 2 ' score doubled when screwdriver used
            DisplayStatus() ' update score
        End If
    End Sub

    Private Function ApplyScrewdriver() As Boolean
        If screwdrivers > 0 Then ' does player have any screwdrivers left?
            ' set player position as stationary
            MoveGrid(pcol, prow) = Grid.PLAYER
            ' determine enemies destroyed
            If pcol > 0 Then
                ScrewEnemy(pcol - 1, prow)
            End If
            If pcol > 0 And prow > 0 Then
                ScrewEnemy(pcol - 1, prow - 1)
            End If
            If prow > 0 Then
                ScrewEnemy(pcol, prow - 1)
            End If
            If pcol < Columns - 1 And prow > 0 Then
                ScrewEnemy(pcol + 1, prow - 1)
            End If
            If pcol < Columns - 1 Then
                ScrewEnemy(pcol + 1, prow)
            End If
            If pcol < Columns - 1 And prow < Rows - 1 Then
                ScrewEnemy(pcol + 1, prow + 1)
            End If
            If prow < Rows - 1 Then
                ScrewEnemy(pcol, prow + 1)
            End If
            If pcol > 0 And prow < Rows - 1 Then
                ScrewEnemy(pcol - 1, prow + 1)
            End If
            screwdrivers = screwdrivers - 1 ' used up a screwdriver
            Return True ' valid move
        Else
            Return False ' invalid move because no screwdrivers were left
        End If
    End Function

    Private Sub NextLevel()
        ' setup for new level
        level = level + 1
        enemies = level * 5 ' number of enemies is a multiple of the level
        If enemies > (CInt(Columns) * CInt(Rows)) - 1 Then
            ' player has reached a level where we no longer have room for all the required enemies as well as the player
            If sound Then
                My.Computer.Audio.Play(My.Resources.impossible, AudioPlayMode.Background)
            End If
            MsgBox("Wow, I thought this was impossible!", MsgBoxStyle.OKOnly, "You win!")
            Me.MenuItem4.Enabled = True ' re-enable Arena menu
            Me.MenuItem9.Enabled = True ' re-enable Grid menu
            Me.PictureBox1.Enabled = False ' no more mouse input
            CheckScores() ' see if they got a high score
            dead = True ' end the game
        End If
        If Not dead Then
            screwdrivers = screwdrivers + 1 ' gain a screwdriver for each new level
            dead = False ' set player status
            wait = False ' set wait status
            ResetGrid(PlayGrid) ' reset playing grid
            ResetGrid(MoveGrid) ' reset working grid
            InitialiseGrid() ' set positions of player and enemies
            DisplayLevel() ' draw the grid, daleks and player position for new level
        End If
    End Sub

    Private Sub SaveScores()
        ' write the high scores list to file
        FileOpen(1, Application.UserAppDataPath & "\WinBots.hs", OpenMode.Binary)
        FilePut(1, HighScores)
        FileClose(1)
    End Sub

    Private Sub InsertScore(ByVal s As Byte)
        ' insert new score into high score file
        Dim pos As Integer ' iterate through high scores
        ' shuffle down all lower scores
        For pos = MAXSCORES - 1 To s + 1 Step -1
            HighScores(pos) = HighScores(pos - 1)
        Next
        ' gather info for new high score and insert into list
        pname = InputBox("Please enter your name: ", "Top Score!", pname)
        HighScores(s).Name = pname
        HighScores(s).Score = score
        HighScores(s).Level = level
        HighScores(s).Screwdrivers = screwdrivers
        HighScores(s).Today = DateTime.Now
        ' write the new high scores to file
        SaveScores()
    End Sub

    Private Sub DisplayScores(ByVal s As Integer)
        ' Display the high score list in a pop-up window.  The s argument specifies which score is to be highlighted.  This is used to highlight the
        ' new entry.
        Dim f As New Form3 ' instantiate the new pop-up
        Dim pos As Byte ' iterate through high scores
        Dim player As String ' hold player name
        f.ListBox1.Items.Clear() ' initialise listbox
        f.ListBox1.Items.Add("Rank" + vbTab + "Score" + vbTab + "Screwdrivers" + vbTab + "Level" + vbTab + "Player" + vbTab + "When") ' header line
        f.ListBox1.Items.Add("") ' blank line
        ' add each high score in the current list
        For pos = 0 To MAXSCORES - 1
            If HighScores(pos).Name = Nothing Then ' program crashes without this check
                player = ""
            Else
                ' truncate the player name to ensure on-screen formatting of high scores is consistent
                player = HighScores(pos).Name.Substring(0, IIf(HighScores(pos).Name.Length > 7, 7, HighScores(pos).Name.Length))
            End If
            ' display the current score
            f.ListBox1.Items.Add((pos + 1).ToString + vbTab + _
                                 HighScores(pos).Score.ToString + vbTab + _
                                 HighScores(pos).Screwdrivers.ToString + vbTab + vbTab + _
                                 HighScores(pos).Level.ToString + vbTab + _
                                 player + vbTab + _
                                 HighScores(pos).Today.ToString)
        Next
        f.ListBox1.SelectedIndex = s + 2 ' highlight the new score
        f.ListBox1.Enabled = False ' disable listbox from processing user clicks
        f.ShowDialog(Me) ' show the high scores
    End Sub

    Private Sub CheckScores()
        ' Check to see if player's score makes it into the top ten list.
        Dim s As Byte ' iterate through scores
        For s = 0 To MAXSCORES - 1
            If score > HighScores(s).Score Then
                ' a better score
                InsertScore(s)
                DisplayScores(s)
                Return
            ElseIf score = HighScores(s).Score Then
                ' an equal score...
                If screwdrivers > HighScores(s).Screwdrivers Then
                    ' ...but with less screwdrivers used so this score ranks higher
                    InsertScore(s)
                    DisplayScores(s)
                    Return
                ElseIf screwdrivers = HighScores(s).Screwdrivers Then
                    ' an equal score and equal screwdrivers...
                    If level < HighScores(s).Level Then
                        ' ...but with less levels so this score ranks higher
                        InsertScore(s)
                        DisplayScores(s)
                        Return
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub PlayerMove(ByVal deltarow As Integer, ByVal deltacol As Integer, ByVal paction As Action)
        ' process player move
        Dim valid As Boolean = True ' true if the player makes a valid move
        Do
            ResetGrid(MoveGrid) ' start with fresh working grid for new move
            ' process player action
            Select Case paction
                Case Action.SCREW
                    ' apply screwdriver
                    valid = ApplyScrewdriver() ' attempt to destroy all adjacent enemies
                    paction = Action.STILL ' to prevent looping
                Case Action.TEL
                    ' teleport
                    ApplyTeleport() 'move to random grid position
                    paction = Action.STILL ' to prevent looping
                Case Action.WAIT
                    ' wait
                    wait = True ' will now loop until player death or all enemies destroyed
                    valid = ApplyMove(Action.STILL, Action.STILL) ' remain where you are
                Case Action.STILL
                    ' move instead of special action
                    valid = ApplyMove(deltarow, deltacol) ' process player movement direction
            End Select
            If Not dead Then
                If valid Then
                    ' remember trash positions
                    KeepTrash()
                    ' move enemies
                    If MoveEnemies() Then
                        If sound Then
                            ' play crash sound
                            My.Computer.Audio.Play(My.Resources.smash, AudioPlayMode.Background)
                        End If
                    End If
                    ' replace old grid with new grid
                    ArrayCopy()
                    ' render new grid
                    DisplayLevel()
                End If
            Else
                ' remember trash positions
                KeepTrash()
                ' remember enemy positions
                KeepEnemies()
                ' replace old grid with new grid
                ArrayCopy()
                ' replace player with death graphic
                PlayGrid(pcol, prow) = Grid.DEATH
                ' render new grid
                DisplayLevel()
            End If
        Loop Until paction = Action.STILL Or dead Or enemies = 0
        If dead Then
            If sound Then
                ' play random death sound
                My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject("dead" + Int(Rnd() * 12).ToString), AudioPlayMode.Background)
            End If
            MsgBox("You died!", MsgBoxStyle.OKOnly, "Game Over") ' notify player
            Me.MenuItem4.Enabled = True ' re-enable Arena menu
            Me.MenuItem9.Enabled = True ' re-enable Grid menu
            CheckScores() ' see if they got a high score
        ElseIf enemies = 0 Then
            If sound Then
                ' play victory sound
                My.Computer.Audio.Play(My.Resources.complete, AudioPlayMode.Background)
            End If
            MsgBox("Level " + level.ToString + " complete.", MsgBoxStyle.OKOnly, "Level Complete") ' notify player
            NextLevel() ' start the next level
        End If
    End Sub

    Private Sub LoadScores()
        ' read in high score file and fill top ten list
        If File.Exists(Application.UserAppDataPath & "\WinBots.hs") Then
            ' file already exists so read it in
            FileOpen(1, Application.UserAppDataPath & "\WinBots.hs", OpenMode.Binary)
            FileGet(1, HighScores)
            FileClose(1)
        Else
            ' if file doesn't already exist, create it
            SaveScores()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        osi = New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height) ' off-screen image
        osg = Graphics.FromImage(osi) ' off-screen graphics
        g = Me.PictureBox1.CreateGraphics ' on-screen graphics initialised
        Randomize() ' start random number generator
        LoadScores() ' load top ten from high score file
        ReDim PlayGrid(Columns - 1, Rows - 1) ' array to record where everything is
        ReDim MoveGrid(Columns - 1, Rows - 1) ' working array during each move
        Me.MenuItem11.Checked = True ' show that no grid will be displayed
        Me.MenuItem19.Checked = True ' show that sound is enabled
        DrawGrid(True) ' draw the grid
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        ' starts a new game
        Dim response As MsgBoxResult
        If dead Then
            newgame()
        Else
            response = MsgBox("You are in the middle of a game.  Do you really want to restart?", vbYesNo, "Restart Game")
            If response = MsgBoxResult.Yes Then
                newgame()
            End If
        End If
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        ' quits the game
        Dim response As MsgBoxResult
        If dead Then
            End
        Else
            response = MsgBox("You are in the middle of a game.  Do you really want to quit?", vbYesNo, "Quit Game")
            If response = MsgBoxResult.Yes Then
                End
            End If
        End If
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Columns = 80 ' number of columns in grid
        Rows = 24 ' number of rows in grid
        ReDim PlayGrid(Columns - 1, Rows - 1) ' array to record where everything is
        ReDim MoveGrid(Columns - 1, Rows - 1) ' working array during each move
        ' set menu selection
        Me.MenuItem5.Checked = True
        Me.MenuItem6.Checked = False
        Me.MenuItem7.Checked = False
        DrawGrid(True)
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Columns = 40 ' number of columns in grid
        Rows = 12 ' number of rows in grid
        ReDim PlayGrid(Columns - 1, Rows - 1) ' array to record where everything is
        ReDim MoveGrid(Columns - 1, Rows - 1) ' working array during each move
        ' set menu selection to 40x12
        Me.MenuItem5.Checked = False
        Me.MenuItem6.Checked = True
        Me.MenuItem7.Checked = False
        DrawGrid(True)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim f As New Form2
        ' set menu selection to custom dimensions
        Me.MenuItem5.Checked = False
        Me.MenuItem6.Checked = False
        Me.MenuItem7.Checked = True
        f.ShowDialog(Me) ' show dialog to allow player to select grid dimensions
        ReDim PlayGrid(Columns - 1, Rows - 1) ' array to record where everything is
        ReDim MoveGrid(Columns - 1, Rows - 1) ' working array during each move
        DrawGrid(True) ' draw grid lines so player can see dimensions
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        ' show high scores
        DisplayScores(-2)
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        ' show grid on arena
        gridlines = True ' grid lines to be drawn during game play
        Me.MenuItem10.Checked = True
        Me.MenuItem11.Checked = False
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        ' hide grid on arena
        gridlines = False ' grid lines not to be drawn during game play
        Me.MenuItem10.Checked = False
        Me.MenuItem11.Checked = True
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        ' Help - About dialog
        My.Forms.AboutBox1.ShowDialog(Me)
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        ' Help - game play instructions dialog
        MsgBox("The object of this game is to escape the onslaught of the robot invasion, destroying them in the process." + vbCrLf + vbCrLf + _
               "You can use your mouse or the keyboard to move about.  Wherever you go, the robots will seek you out." + vbCrLf + vbCrLf + _
               "Stay alive as long as possible through cunning, teleporting and use of your sonic screwdriver to " + _
               "vaporise the robots adjacent to you.  You recharge your sonic screwdriver once each level " + _
               "and if you do not use it, the charge accumulates.", MsgBoxStyle.OkOnly, "Instructions")
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        ' Help - keyboard controls dialog
        MsgBox("Numeric Keypad " + vbTab + vbTab + vbTab + "Move in all possible directions." + vbCrLf + _
               "(with or without NumLock on)" + vbCrLf + vbCrLf + _
               "SPACE or 5" + vbTab + vbTab + vbTab + "Remain stationary for 1 turn." + vbCrLf + vbCrLf + _
               "S" + vbTab + vbTab + vbTab + vbTab + "Activates your sonic screwdriver to" + vbCrLf + _
               vbTab + vbTab + vbTab + vbTab + "obliterate the adjacent robots." + vbCrLf + _
               vbTab + vbTab + vbTab + vbTab + "Each robot is worth double points" + vbCrLf + _
               vbTab + vbTab + vbTab + vbTab + "when destroyed by screwdriver." + vbCrLf + vbCrLf + _
               "T" + vbTab + vbTab + vbTab + vbTab + "Teleport." + vbCrLf + vbCrLf + _
               "W" + vbTab + vbTab + vbTab + vbTab + "Wait until all enemies have moved" + vbCrLf + _
               vbTab + vbTab + vbTab + vbTab + "to their doom or destroy you so use" + vbCrLf + _
               vbTab + vbTab + vbTab + vbTab + "wisely!  Each robot is worth triple" + vbCrLf + _
               vbTab + vbTab + vbTab + vbTab + "points while you wait.", MsgBoxStyle.OkOnly, "Keyboard Controls")
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        ' Help - mouse controls dialog
        MsgBox("LEFT button" + vbTab + "Travel in the direction of the pointer when clicked." + vbCrLf + _
               vbTab + vbTab + "Remain stationary for 1 turn if you click on yourself." + vbCrLf + vbCrLf + _
               "MIDDLE button" + vbTab + "Wait until all enemies have moved to their doom or" + vbCrLf + _
               vbTab + vbTab + "destroy you so use wisely!" + vbCrLf + _
               vbTab + vbTab + "Each robot is worth triple points while you wait." + vbCrLf + vbCrLf + _
               "RIGHT button" + vbTab + "Activates your sonic screwdriver to obliterate the" + vbCrLf + _
               vbTab + vbTab + "adjacent robots." + vbCrLf + _
               vbTab + vbTab + "Each robot is worth double points when destroyed in" + vbCrLf + _
               vbTab + vbTab + "this way.", MsgBoxStyle.OkOnly, "Mouse Controls")
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        ' Help - scoring dialog
        MsgBox("Each robot is worth 1 point when it is destroyed by colliding with another." + vbCrLf + vbCrLf + _
               "Each robot is worth 2 points when destroyed by your sonic screwdriver." + vbCrLf + vbCrLf + _
               "Each robot is worth 3 points when destroyed while you wait." + vbCrLf + vbCrLf + _
               "The High Scores list is ordered first by score, secondly by number of remaining screwdrivers and thirdly by level reached." + vbCrLf + _
               "Thus if two scores are equal, the score with more remaining screwdrivers is ranked higher." + vbCrLf + _
               "If two scores are equal and have an equal number of remaining screwdrivers, the score achieved with the lower level is ranked higher.", MsgBoxStyle.OKOnly, "Scoring")
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        ' Sound option on
        sound = True
        ' set menu selection
        Me.MenuItem19.Checked = True
        Me.MenuItem20.Checked = False
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        ' Sound option off
        sound = False
        ' set menu selection
        Me.MenuItem19.Checked = False
        Me.MenuItem20.Checked = True
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        ' process keyboard input
        If Not moving Then ' we only want one keyboard input at a time
            moving = True
            Select Case e.KeyCode
                Case Keys.Home, Keys.NumPad7, Keys.Q, Keys.D7 ' up and left
                    PlayerMove(mUP, mLEFT, Action.STILL)
                Case Keys.Up, Keys.NumPad8, Keys.D8 ' up
                    PlayerMove(mUP, Action.STILL, Action.STILL)
                Case Keys.PageUp, Keys.NumPad9, Keys.D9 ' up and right
                    PlayerMove(mUP, mRIGHT, Action.STILL)
                Case Keys.Left, Keys.NumPad4, Keys.D4 ' left
                    PlayerMove(Action.STILL, mLEFT, Action.STILL)
                Case Keys.S ' screwdriver
                    PlayerMove(Action.STILL, Action.STILL, Action.SCREW)
                Case Keys.Right, Keys.NumPad6, Keys.D6 ' right
                    PlayerMove(Action.STILL, mRIGHT, Action.STILL)
                Case Keys.End, Keys.NumPad1, Keys.D1 ' down and left
                    PlayerMove(mDOWN, mLEFT, Action.STILL)
                Case Keys.Down, Keys.NumPad2, Keys.D2 ' down
                    PlayerMove(mDOWN, Action.STILL, Action.STILL)
                Case Keys.PageDown, Keys.NumPad3, Keys.D3 ' down and right
                    PlayerMove(mDOWN, mRIGHT, Action.STILL)
                Case Keys.Space, Keys.NumPad5, Keys.D5 ' pause for just one turn
                    PlayerMove(Action.STILL, Action.STILL, Action.STILL)
                Case Keys.W ' wait
                    PlayerMove(Action.STILL, Action.STILL, Action.WAIT)
                Case Keys.T ' teleport
                    PlayerMove(Action.STILL, Action.STILL, Action.TEL)
            End Select
            If Not dead Then
                moving = False
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        ' process mouse clicks
        If Not moving Then ' we only want one player move at a time
            moving = True
            Select Case dir
                Case Directions.UP
                    PlayerMove(mUP, Action.STILL, Action.STILL)
                Case Directions.DOWN
                    PlayerMove(mDOWN, Action.STILL, Action.STILL)
                Case Directions.LEFT
                    PlayerMove(Action.STILL, mLEFT, Action.STILL)
                Case Directions.RIGHT
                    PlayerMove(Action.STILL, mRIGHT, Action.STILL)
                Case Directions.UPLEFT
                    PlayerMove(mUP, mLEFT, Action.STILL)
                Case Directions.UPRIGHT
                    PlayerMove(mUP, mRIGHT, Action.STILL)
                Case Directions.DOWNLEFT
                    PlayerMove(mDOWN, mLEFT, Action.STILL)
                Case Directions.DOWNRIGHT
                    PlayerMove(mDOWN, mRIGHT, Action.STILL)
                Case Directions.ZAP
                    If e.Button = MouseButtons.Left Then
                        PlayerMove(Action.STILL, Action.STILL, Action.STILL)
                    ElseIf e.Button = MouseButtons.Right Then
                        PlayerMove(Action.STILL, Action.STILL, Action.SCREW)
                    Else ' middle mouse button
                        PlayerMove(Action.STILL, Action.STILL, Action.WAIT)
                    End If
            End Select
            If Not dead Then
                moving = False
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        ' monitor mouse position in grid to determine cursor shape
        If dead Then
            Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default ' reset cursor to default arrow
        Else
            ' set cursor shape to indicate direction of movement
            If e.X < pcol * gridwidth Then
                If e.Y < prow * gridheight Then
                    Me.PictureBox1.Cursor = cUPLEFT
                    dir = Directions.UPLEFT
                ElseIf e.Y > (prow + 1) * gridheight Then
                    Me.PictureBox1.Cursor = cDOWNLEFT
                    dir = Directions.DOWNLEFT
                Else
                    Me.PictureBox1.Cursor = cLEFT
                    dir = Directions.LEFT
                End If
            ElseIf e.X > (pcol + 1) * gridwidth Then
                If e.Y < prow * gridheight Then
                    Me.PictureBox1.Cursor = cUPRIGHT
                    dir = Directions.UPRIGHT
                ElseIf e.Y > (prow + 1) * gridheight Then
                    Me.PictureBox1.Cursor = cDOWNRIGHT
                    dir = Directions.DOWNRIGHT
                Else
                    Me.PictureBox1.Cursor = cRIGHT
                    dir = Directions.RIGHT
                End If
            Else
                If e.Y < prow * gridheight Then
                    Me.PictureBox1.Cursor = cUP
                    dir = Directions.UP
                ElseIf e.Y > (prow + 1) * gridheight Then
                    Me.PictureBox1.Cursor = cDOWN
                    dir = Directions.DOWN
                Else
                    Me.PictureBox1.Cursor = cZAP
                    dir = Directions.ZAP
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        ' repaint the current image
        e.Graphics.DrawImage(osi, 0, 0)
    End Sub

End Class
