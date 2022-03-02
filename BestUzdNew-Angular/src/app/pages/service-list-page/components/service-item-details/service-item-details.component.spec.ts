import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServiceItemDetailsComponent } from './service-item-details.component';

describe('ServiceItemDetailsComponent', () => {
  let component: ServiceItemDetailsComponent;
  let fixture: ComponentFixture<ServiceItemDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ServiceItemDetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ServiceItemDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
