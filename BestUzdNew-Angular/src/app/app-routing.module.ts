import { NgModule } from '@angular/core';
import { Route, RouterModule, Routes } from '@angular/router';
import { ServiceItemDetailsComponent } from './pages/service-list-page/components/service-item-details/service-item-details.component';
import { serviceItems } from './pages/service-list-page/service-list.data';
function formServiceRoutes(): Routes {
  const routes: Routes = [];

  serviceItems.forEach(serviceItem => {
    const route: Route = {
      path: serviceItem.url,
      component: ServiceItemDetailsComponent,
    }

    if (serviceItem.childs.length) {
      route.children = serviceItem.childs.map(x => ({
        path: x.url,
        component: ServiceItemDetailsComponent
      }))
    }

    routes.push(route);
  });

  return routes;
}
const routes: Routes = [
  {
    path: '',
    loadChildren: () => import('./pages/home-page/home-page.module').then(x => x.HomePageModule)
  },
  {
    path: 'Контакти',
    loadChildren: () => import('./pages/contacts-page/contacts-page.module').then(x => x.ContactsPageModule)
  },
  {
    path: 'Послуги',
    loadChildren: () => import('./pages/service-list-page/service-list-page.module').then(x => x.ServiceListPageModule),
  },
  {
    path: 'Про-клініку',
    loadChildren: () => import('./pages/about-page/about-page.module').then(x => x.AboutPageModule),
  },
  ...formServiceRoutes()];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
