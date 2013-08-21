define([
    "dojo/_base/declare"
    ,"dgrid/Grid"],
   function(declare, Grid)
   {
   		return declare("fullstack.Grid1", [Grid],
        {
			myProperty:"something"
        });
   });