import { Component, OnInit } from '@angular/core';
import { ItemService } from 'src/app/services/APIs/itemService/item.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(public itemService: ItemService) { }

  ngOnInit(): void {
    this.itemService.refreshList();
  }

}
