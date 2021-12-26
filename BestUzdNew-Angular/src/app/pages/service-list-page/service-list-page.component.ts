import { Component, OnInit } from '@angular/core';
import { ServiceItemData } from './service-item-data';

@Component({
  selector: 'app-service-list-page',
  templateUrl: './service-list-page.component.html',
  styleUrls: ['./service-list-page.component.scss']
})
export class ServiceListPageComponent implements OnInit {
  serviceItems: ServiceItemData[] = [
    {
      title: 'Дiагностика',
      description: 'Зробити УЗД може фахівець, що володіє навичками роботи з відповідним устаткуванням. У його компетенції - попередній огляд і виписка висновків, по яких профільні лікарі можуть поставити діагноз.',
      active: false,
      url: 'диагностика',
      childs: [
        {
          title: 'УЗД лімфовузлів',
          price: 350,
          url: 'УЗД-лшмфоузлов'
        },
        {
          title: 'УЗД м’яких тканин',
          price: 350,
          url: 'УЗД-мягких-тканей'
        },
        {
          title: 'УЗД судин шиї',
          price: 350,
          url: 'УЗД-сосудов-шеи'
        },
        {
          title: 'УЗД молочних залоз',
          price: 350,
          url: 'УЗД-молочных-желез'
        },
      ]
    },
    {
      title: 'Гастроентеролог',
      description: '',
      active: false,
      url: 'Гастроэнтерология',
      childs: []
    },
    {
      title: 'Вагітність',
      description: '',
      active: false,
      url: 'Беременность',
      childs: []
    },
  ]

  selectService(service: ServiceItemData) {
    if (service.active) {
      service.active = !service.active;
      return;
    }
    this.serviceItems.forEach(x => x.active = false);
    service.active = true;
  }

  constructor() { }

  ngOnInit(): void {
  }
}
