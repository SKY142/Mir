/**
 * Created by Mir on 9/23/2014.
 */
var app = angular.module("myModule",[]);
app.service("DB",function(){
    var StudentId = "-1";
    var sData = [{
        name:'Sky',
        Age: '20'
    }];
    this.getSData = function (){
        return sData;
    };
    this.setSData = function (data){
        sData.push(data);
    };
    this.delData = function(id){
        sData.splice(id, 1);
     };
    this.singleData = function(id){
                return sData[id];
    };
    this.updateData = function(data,id){
        sData[id] = data;
    }
    this.setId = function(id){
        StudentId = id;
    }
    this.getId = function(){
        return StudentId;
    }
});

app.controller("showStudentData", function($scope,DB,$interval) {
    $scope.localId = "-1";
    $interval(function(){
        $scope.localId = DB.getId();
    },1000);

    if($scope.localId != "-1")
    {
        $scope.student = DB.singleData($scope.localId);
    }
    else
    {
        $scope.student = {name:"",Age:""};
    }
    $scope.Add = function(){
        if($scope.localId == "-1")
        {
            DB.setSData($scope.student);
        }
        else
        {
            DB.updateData($scope.student,$scope.localId);
            DB.setId("-1");
        }
        $scope.student={};
    };
    });
app.controller("showFullData",function($scope,DB){
   $scope.items = DB.getSData();
    $scope.delete = function(id){

        DB.delData(id);
    };

    $scope.update = function(id){
        DB.setId(id);
    };
});