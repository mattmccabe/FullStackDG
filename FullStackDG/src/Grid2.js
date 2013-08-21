define([
    "dojo/_base/declare"
    ,"dgrid/Grid"
    ,"dgrid/Selection"
    ,"dgrid/Keyboard"],
   function(declare, Grid, Selection, Keyboard)
   {
   		return declare("fullstack.Grid2", [Grid, Selection, Keyboard],
        {
			myProperty:"something"
        });
   });