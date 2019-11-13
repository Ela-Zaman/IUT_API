var app = angular.module('myApp', ['angularFileUpload']);

app.controller('MyCtrl', function($scope, fileReader) {

  function toCamelCase(s) {
    
      // remove all characters that should not be in a variable name
      // as well underscores an numbers from the beginning of the string
      s = s.replace(/([^a-zA-Z0-9_\- ])|^[_0-9]+/g, "").trim().toLowerCase();
      
      // uppercase letters preceeded by a hyphen or a space
      s = s.replace(/([ -]+)([a-zA-Z0-9])/g, function(a,b,c) {
          return c.toUpperCase();
      });
      
      // uppercase letters following numbers
      s = s.replace(/([0-9]+)([a-zA-Z])/g, function(a,b,c) {
          return b + c.toUpperCase();
      });
      
      return s;
  }
      
  function rename(objects) {
    var headers = Object.keys(objects[0]);
    
    for (var i = 0; i < objects.length; i++) {
      var object = objects[i];
      
      for (var j = 0; j < headers.length; j++) {
        if (object.hasOwnProperty(headers[j])) {
            object[toCamelCase(headers[j])] = object[headers[j]];
            delete object[headers[j]];
        }    
      }
    }
  }
  $scope.onFileSelect = function($files) {
    //$files: an array of files selected, each file has name, size, and type.
    for (var i = 0; i < $files.length; i++) {
      var file = $files[i];
      fileReader.readAsText(file, $scope)
        .then(function(result) {
          objects = $.csv.toObjects(result);
          rename(objects);
          $scope.csvResults = objects;
      });
    }
  }
});

app.factory('fileReader', function($q, $log) {
  var onLoad = function(reader, deferred, scope) {
    return function () {
      scope.$apply(function () {
        deferred.resolve(reader.result);
      });
    };
  };

  var onError = function (reader, deferred, scope) {
    return function () {
      scope.$apply(function () {
        deferred.reject(reader.result);
      });
    };
  };

  var onProgress = function(reader, scope) {
    return function (event) {
      scope.$broadcast("fileProgress",
        {
          total: event.total,
          loaded: event.loaded
        });
    };
  };

  var getReader = function(deferred, scope) {
    var reader = new FileReader();
    reader.onload = onLoad(reader, deferred, scope);
    reader.onerror = onError(reader, deferred, scope);
    reader.onprogress = onProgress(reader, scope);
    return reader;
  };

  var readAsDataURL = function (file, scope) {
    var deferred = $q.defer();
     
    var reader = getReader(deferred, scope);         
    reader.readAsDataURL(file);
     
    return deferred.promise;
  };

  var readAsText = function (file, scope) {
    var deferred = $q.defer();
     
    var reader = getReader(deferred, scope);         
    reader.readAsText(file);
     
    return deferred.promise;
  };

  return {
    readAsDataUrl: readAsDataURL,  
    readAsText: readAsText  
  };
});