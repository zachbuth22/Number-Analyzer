import { Component } from '@angular/core';
import { MenuItem } from './models/menu-item';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ChirpusPizza';

allItems: MenuItem [] = [
  {
    Name: "Hot Wings",
    Category: "Wings",
    Price: 10
  },
  {
    Name: "BBQ Wings",
    Category: "Wings",
    Price: 10
  },
  {
    Name: "One Topping",
    Category: "Pizza",
    Price: 12
  },
  {
    Name: "Two Toppings",
    Category: "Pizza",
    Price: 14
  },
  {
    Name: "Soda",
    Category: "Drinks",
    Price: 3
  },
  {
    Name: "Beer",
    Category: "Drinks",
    Price: 4
  },
];


newmenuitem:MenuItem[]=[];
getByCategory(cat: string):MenuItem[]{
  this.newmenuitem.length=0;
this.allItems.forEach((c:MenuItem) => {
  if(c.Category == cat){
    this.newmenuitem.push(c);
  }
});
    return this.newmenuitem;
}

// Wings:MenuItem[]= this.getByCategory("Wings");
// Pizza:MenuItem[]= this.getByCategory("Pizza");
// Drinks:MenuItem[]= this.getByCategory("Drinks");

};