import { NgModule } from '@angular/core';
import { Route, RouterModule, Routes } from '@angular/router';
import { ServiceItemDetailsComponent } from './components/service-item-details/service-item-details.component';
import { ServiceListPageComponent } from './service-list-page.component';
import { serviceItems } from './service-list.data';

function formServiceRoutes() {
  const routes: Routes = [];

  serviceItems.forEach(serviceItem => {
    const route: Route = {
      path: serviceItem.url,
      component: ServiceItemDetailsComponent,
    }
    
    if (serviceItem.childs.length) {
      route.children = serviceItem.childs.map(x => ({
        path: x. url,
        component: ServiceListPageComponent
      }))
    }

    routes.push(route);
  });

  return routes;
}

const routes: Routes = [
  {
    path: '',
    component: ServiceListPageComponent,
    children: formServiceRoutes()
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ServiceListPageRoutingModule { }
