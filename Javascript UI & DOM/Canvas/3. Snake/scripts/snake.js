var snakeGame = function () {

    this.startGame = function () {
        this.isRunning = true;
        
        keyboardInput();

        gameLoop = setInterval(function () {

            if (!hasCrashedIntoWall() && !hasCrashedIntoBody()) {
                drawBoard();
                snake.update();
                tryEatFood();
            }
            else {
                submitScore(score);
                clearInterval(gameLoop);
                isRunning = false;
                ctx.clearRect(0, 0, CANVAS_WIDTH, CANVAS_HEIGHT);
            }
        }, 100);
    }

    this.stopGame = function () {
        clearInterval(gameLoop);
        isRunning = false;
        ctx.clearRect(0, 0, CANVAS_WIDTH, CANVAS_HEIGHT);
    }

    var gameBlock = function (positionX, positionY) {

        this.positionX = positionX;
        this.positionY = positionY;
    }

    var Snake = function () {

        this.directionX = 5;
        this.directionY = 0;
        this.head = new gameBlock(20, 20);
        this.body = [new gameBlock(15, 20), new gameBlock(10, 20), new gameBlock(5, 20), new gameBlock(0, 20)];
        
        this.update = function () {

            for (var i = 0; i < this.body.length; i++) {
                if (this.head.positionX == this.body[i].positionX && this.head.positionY == this.body[i].positionY) {
                    return false;
                }
            }
            this.body.pop();
            this.body.unshift(this.head);
            this.head = new gameBlock(this.head.positionX + this.directionX, this.head.positionY + this.directionY);
            
            return true;
        }

        this.grow = function () {
            this.body.push(new gameBlock(this.body[this.body.length - 1]));
            this.body.push(new gameBlock(this.body[this.body.length - 1]));
        }
    }

    var Food = function (positionX, positionY) {

        this.positionX = positionX
        this.positionY = positionY;
    }

    var generateFood = function () {
        
        var randomPositionX = Math.floor(Math.random() * (canvas.width - 0 + 1)) + 0;
        randomPositionX = randomPositionX - randomPositionX % BLOCK_WIDTH;
        var randomPositionY = Math.floor(Math.random() * (canvas.height - 0 + 1)) + 0;
        randomPositionY = randomPositionY - randomPositionY % BLOCK_WIDTH;

        var food = new Food(randomPositionX, randomPositionY);
        return food;
    }

    var drawBoard = function () {
        ctx.clearRect(0, 0, canvas.width, canvas.height);

        //Draw snake
        ctx.fillStyle = '#2aff00';
        ctx.fillRect(snake.head.positionX, snake.head.positionY, BLOCK_WIDTH, BLOCK_HEIGHT);
        ctx.fillStyle = '#bdf72d';
        for (var i = 0; i < snake.body.length; i++) {
            ctx.fillRect(snake.body[i].positionX, snake.body[i].positionY, BLOCK_WIDTH, BLOCK_HEIGHT);
        }
        ctx.fillStyle = 'red';
        //Draw Food
        ctx.fillRect(food.positionX, food.positionY, BLOCK_WIDTH, BLOCK_HEIGHT);
    }

    var keyboardInput = function () {
        document.onkeydown = function (event) {
            switch (event.keyCode) {
                case 38: // up

                    if (snake.directionX != 0 && snake.directionY != 5) {
                        snake.directionX = 0;
                        snake.directionY = -5;
                    }
                    break;
                case 40: // down

                    if (snake.directionX != 0 && snake.directionY != -5) {
                        snake.directionX = 0;
                        snake.directionY = 5;
                    }
                    break;
                case 37: // left

                    if (snake.directionX != 5 && snake.directionY != 0) {
                        snake.directionX = -5;
                        snake.directionY = 0;
                    }
                    
                    break;
                case 39: // right
                    if (snake.directionX != -5 && snake.directionY != 0) {
                        snake.directionX = 5;
                        snake.directionY = 0;
                    }
                    
                    break;
                default: break;

            }
        }
    }

    var hasCrashedIntoWall = function () {
        if (snake.head.positionX < 0 || snake.head.positionY < 0 ||
                snake.head.positionX > canvas.width - 5 || snake.head.positionY > canvas.height - 5) {
            return true;
        }
        return false;
    }

    var hasCrashedIntoBody = function () {
        for (var i = 0; i < snake.body.length; i++) {
            if (snake.head.positionX == snake.body[i].positionX && snake.head.positionY == snake.body[i].positionY) {
                return true;
            }
        }
        return false;
    }

    var updateScore = function () {
        score++;
        SCORE_DISPLAY.innerHTML = score;
    }

    var resetScore = function () {
        score = 0;
        SCORE_DISPLAY.innerHTML = score;
    }

    var submitScore = function (score) {

        var sortFunction = function (a, b) {
            return b.score - a.score;
        };

        var sortedLocalStorage = [];

        for (var name in localStorage) {
            sortedLocalStorage.push({ name: name, score: localStorage[name] });
        }

        sortedLocalStorage.sort(sortFunction);

        if (sortedLocalStorage.length < 5) {
            var name = prompt('Congratulations! You are in our top five score chart. Please Enter your name:');
            localStorage.setItem(name, score);
        }
        else if (score > sortedLocalStorage[4].score) {
            var name = prompt('Congratulations! You are in our top five score chart. Please Enter your name:');
            localStorage.setItem(name, score);
        }
        resetScore();

        var newGame = confirm('New game?');
        if (newGame) {
            newSnakeGame = new snakeGame();
            newSnakeGame.startGame();
        }
        else {
            newSnakeGame = undefined;
        }
        
    }

    var tryEatFood = function () {
        if (snake.head.positionX == food.positionX && snake.head.positionY == food.positionY) {
            snake.grow();
            updateScore();
            food = generateFood();
            tryRemoveFoodFromSnakeBody();
        }
    }

    var tryRemoveFoodFromSnakeBody = function () {
        while (snake.head.positionX == food.positionX && snake.head.positionY == food.positionY) {
            food = generateFood();
        }
        for (var i = 0; i < snake.body.length; i++) {
            while (snake.body[i].positionX == food.positionX && snake.body[i].positionY == food.positionY) {
                food = generateFood();
            }
        }
    }

    var canvas = document.getElementById('snakeGame');
    var CANVAS_WIDTH = canvas.width;
    var CANVAS_HEIGHT = canvas.height;
    var ctx = canvas.getContext('2d');
    var score = 0;
    var SCORE_DISPLAY = document.getElementById('score');
    var BLOCK_WIDTH = 5;
    var BLOCK_HEIGHT = 5;
    var gameLoop;
    var snake = new Snake();
    var food = generateFood();
}



var newSnakeGame;
var onClickStartGame = function () {
    if (!newSnakeGame) {
        newSnakeGame = new snakeGame();
        newSnakeGame.startGame();
    }
    else {
        newSnakeGame.stopGame();
        newSnakeGame = new snakeGame();
        newSnakeGame.startGame();
    }
    
}

var onClickStopGame = function () {
    if (newSnakeGame) {
        newSnakeGame.stopGame();
        newSnakeGame = undefined;
    }
}