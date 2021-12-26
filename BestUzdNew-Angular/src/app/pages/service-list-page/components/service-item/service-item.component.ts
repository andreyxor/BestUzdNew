import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ServiceItemData } from '../../service-item-data';

@Component({
  selector: 'app-service-item',
  templateUrl: './service-item.component.html',
  styleUrls: ['./service-item.component.scss']
})
export class ServiceItemComponent implements OnInit {
  @Input()
  public data!: ServiceItemData;

  @Output('serviceItemClicked')
  public serviceItemClicked$ = new EventEmitter<ServiceItemData>();

  serviceItemClicked() {
    this.serviceItemClicked$.emit(this.data);
  }

  constructor() { }

  ngOnInit(): void {
  }
}
