# Tic Tac Toe Game
# Hack Day Challenge
# Holberton School. May, 2020


# Matrix of Tic Tac Toe Borad
$board = @((' ', '1','2','3'),('1', ' ', ' ', ' '), ('2', ' ', ' ', ' '), ('3', ' ', ' ', ' '))

# in_board - Update Matrix with value in desire position
# Arguments:
#    $pre_board: array of board
#    $x: integer - row position
#    $y: integer - row position
#    $str: string - value to insert
# Return:
#    Array updated
function in_board($pre_board, $x, $y, $str) {
    if ($pre_board[$x][$y] -eq ' ') {
        $pre_board[$x][$y] = $str;
    } else {
        Write-host "Taken"
    }

    return $pre_board;
}


# print_board - print array
# Arguments:
#    $pre_board: array of board
function print_board($pre_board) {
cls
    $i = 0
    while($i -lt 4) {
        $pre_board[$i] -join ' | ';
        $i++
    }
}


# check_row - check if row is full
# Arguments:
#    $board: array of board
#    $str - check value 'X' or 'O'
# Return:
#    if it is full returns 1 if not returns 0
function check_row($board, $str) {
    $i = 1
    while($i -lt 4)
    {
        if(($board[$i][1] -eq $str) -and ($board[$i][2] -eq $str) -and ($board[$i][3] -eq $str)) {
            return 1
        }
        $i = $i + 1
    }
}


# check_col - check if col is full
# Arguments:
#    $board: array of board
#    $str - check value 'X' or 'O'
# Return:
#    if it is full returns 1 if not returns 0
function check_col($board, $str) {
    $i = 1
    while($i -lt 4)
    {
        if(($board[1][$i] -eq $str) -and ($board[2][$i] -eq $str) -and ($board[3][$i] -eq $str)) {
            return 1
        }
        $i = $i + 1
    }
}


# check_diag - check if diagonal is full
# Arguments:
#    $board: array of board
#    $str - check value 'X' or 'O'
# Return:
#    if it is full returns 1 if not returns 0
function check_diag($board, $str) {
    if(($board[1][1] -eq $str) -and ($board[2][2] -eq $str) -and ($board[3][3] -eq $str)) {
        return 1
    }

    if(($board[1][3] -eq $str) -and ($board[2][2] -eq $str) -and ($board[3][1] -eq $str)) {
        return 1
    }
}


cls
print_board($board)

# Main Loop of the game
# Arguments:
#    $state: integer - count with bumber of movements
#    $checkUser: switch between users. 0 is user 1, 1 is user 2

$state = 0
$checkUser = 0
while($state -lt 50) {

    # User 1
    if ($checkUser -eq 0) {
        Write-host User 1. Enter Position
        $x = read-host Row
        $y = read-host Column

        if ($board[$x][$y] -ne ' ')
        {
            Write-host "Position Taken!"
            $state = $state - 1
            continue;
        }

        $board = in_board $board $x $y 'X'

        print_board $board
        $state = $state + 1
        $winner_row = check_row $board 'X'
        if ($winner_row -eq 1) {
            Write-host "User 1 wins!"
            break;
        }
        $winner_col = check_col $board 'X'
        if ($winner_col -eq 1) {
            Write-host "User 1 wins!"
            break;
        }
        $winner_diag = check_diag $board 'X'
        if ($winner_diag -eq 1) {
            Write-host "User 1 wins!"
            break;
        }

        if ($state -eq 9) {
            Write-host "No more options. End of game!"
            break;
        }

        $checkUser = 1
    }

    #User 2
    if ($checkUser -eq 1) {
        Write-host User 2. Enter Position
        $x = read-host Row
        $y = read-host Column

        if ($board[$x][$y] -ne ' ')
        {
            Write-host "Position Taken!"
            $state = $state - 1
            continue;
        }

        $board = in_board $board $x $y 'O'
        print_board $board
        $state = $state + 1
        $winner_row = check_row $board 'O'
        if ($winner_row -eq 1) {
            Write-host "User 2 wins!"
            break;
        }
        $winner_col = check_col $board 'O'
        if ($winner_col -eq 1) {
            Write-host "User 2 wins!"
            break;
        }
        $winner_diag = check_diag $board 'O'
        if ($winner_diag -eq 1) {
            Write-host "User 2 wins!"
            break;
        }

        $checkUser = 0
    }
}