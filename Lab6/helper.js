Array.prototype.getMax = function () {
  var result = {};
  result.unique = true;
  result.value = null;
  result.index = null;

  for (var i = 0; i < this.length; i++) {
    if (result.value == null) {
      result.index = i;
      result.value = this[i];
    } else {
      if (result.value < this[i]) {
        result.index = i;
        result.value = this[i];
      } else {
        if (this[i] === result.value) {
          result.unique = false;
        }
      }
    }
  }
  return result;
};

Array.prototype.multiplyArray = function (array) {
  var length = this.length > array.length ? this.length : array.length;
  var temp = new Array(length);
  for (var i = 0; i < length; i++) {
    temp[i] = this[i] * array[i];
  }
  return temp;
};

Array.prototype.differenceArray = function (array) {
  var length = this.length > array.length ? this.length : array.length;
  var temp = new Array(length);
  for (var i = 0; i < length; i++) {
    temp[i] = this[i] - array[i];
  }
  return temp;
};

Array.prototype.sumArray = function (array) {
  var length = this.length > array.length ? this.length : array.length;
  var temp = new Array(length);
  for (var i = 0; i < length; i++) {
    temp[i] = this[i] + array[i];
  }
  return temp;
};

Array.prototype.fillArray = function (n) {
  this.fill(0);
  this.forEach((element, index, array) => (array[index] = Array(n)));
  return this;
};

Array.prototype.fillArrayRandom = function (n, min, max) {
  this.fill(0);
  this.forEach((element, index, array) => (array[index] = Array(n).fillRandom(min, max)));
  return this;
};

Array.prototype.fillRandom = function (min, max) {
  this.fill(0);
  this.forEach((element, index, array) => (array[index] = Math.round(min + Math.random() * (max - min))));
  return this;
};

Array.prototype.mx = function () {
  return this.reduce((a, b) => a + b) / this.length;
};

Array.prototype.sigma = function () {
  var sigma = 0;
  var mx = this.mx();
  this.forEach((element) => (sigma += Math.pow(element - mx, 2)));
  return Math.sqrt(sigma / this.length);
};

function Canvas() {
  var _obj = {},
    canvas = null,
    step = 20,
    ctx = null,
    colors = [
      "#000000",
      "#ff0000",
      "#00ff00",
      "#00ffff",
      "#0000ff",
      "#0b670b",
      "#ffff00",
      "#ff00ff",
      "#797915",
      "#ff66cc",
    ];

  _obj.setStep = function (x) {
    step = x;
  };

  _obj.DrawText = function (x, y, c, str) {
    ctx.font = "14px Times";
    ctx.fillStyle = colors[c];
    ctx.fillText(str, x, y);
  };

  function DrawPixel(x, y, c, size) {
    ctx.fillStyle = colors[c];
    ctx.fillRect(400 + x * step, 600 - (300 + y * step), size, size);
  }

  _obj.DrawLine2 = function (x, y, c, x1, x2, k) {
    if (Math.abs(x2 - y) < 600) {
      ctx.beginPath();
      ctx.lineWidth = k;
      ctx.strokeStyle = colors[c];
      ctx.moveTo(400 + x * step, 300 - y * step);
      ctx.lineTo(400 + x1 * step, 300 - x2 * step);
      ctx.stroke();
    }
  };

  _obj.DrawLine = function (x, y, c, x1, x2, k) {
    ctx.beginPath();
    ctx.lineWidth = k;
    ctx.strokeStyle = colors[c];
    ctx.moveTo(x, y);
    ctx.lineTo(x1, x2);
    ctx.stroke();
  };

  _obj.DrawArray = function (arr, size) {
    for (var i = 0; i < arr.length; i++) {
      DrawPixel(arr[i].x, arr[i].y, arr[i].c, size);
    }
  };

  _obj.DrawArray2 = function (arr, size) {
    for (var i = 0; i < arr.length - 1; i++) {
      _obj.DrawLine2(arr[i].x, arr[i].y, arr[i].c, arr[i + 1].x, arr[i + 1].y);
    }
  };

  _obj.DrawArrayLine = function (arr, arr2) {
    for (var i = 0; i < arr.length; i++) {
      DrawLine(arr[i].x, arr[i].y, arr[i].c, arr2[arr[i].c].x, arr2[arr[i].c].y);
    }
  };

  _obj.Clear = function () {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
  };

  _obj.Init = function (canvasId) {
    canvas = document.getElementById(canvasId);
    ctx = canvas.getContext("2d");
  };

  return _obj;
}
