﻿namespace pruebagit.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

type HomeController (logger : ILogger<HomeController>) =
    inherit Controller()

   
     
      member string name1 = "Aged Brie";
      member string name2 = "Backstage passes to a TAFKAL80ETC concert";
       member string name3 = "Sulfuras, Hand of Ragnaros";
        

       