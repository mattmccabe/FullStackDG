FullStackDG
===========
Presentation at [AZ Software Community Meetup](http://www.meetup.com/azsoftcom/events/124645792/)

Dependencies
------------
* [xstyle](https://github.com/kriszyp/xstyle)
* [dgrid](https://github.com/sitepen/dgrid) 
* [put-selector](https://github.com/kriszyp/put-selector)
* MongoDB local install
* [Zips.json](http://docs.mongodb.org/manual/tutorial/aggregation-examples/) data imported into a database called _fullstackdg_ and collection called _zips_ 
* MongoDB [CSharp Driver](http://docs.mongodb.org/ecosystem/drivers/csharp/)
* [ServiceStack](http://servicestack.net) 

A few notes:
* xstyle, dgrid and put-selector dependencies should be located/extracted/symlinked as a sibling to FullStackDG/src
* dgrid version at the time was 0.3 and was referred to as dgrid-0.3 in the symlink I created as a sibling to FullStackDG/src
* Dojo is included from CDN 
* In the grid3.html example you will need to specify your own API Key for the google maps API that is used.
