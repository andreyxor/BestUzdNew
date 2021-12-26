import { Component, Input, OnInit } from '@angular/core';
import { ChildServiceItemData } from '../../service-item-data';

@Component({
  selector: 'app-child-service-item',
  templateUrl: './child-service-item.component.html',
  styleUrls: ['./child-service-item.component.scss']
})
export class ChildServiceItemComponent implements OnInit {
  @Input()
  public data!: ChildServiceItemData;

  constructor() { }

  ngOnInit(): void {
  }

}
