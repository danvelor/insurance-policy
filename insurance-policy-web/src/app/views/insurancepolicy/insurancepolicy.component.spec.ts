import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InsurancepolicyComponent } from './insurancepolicy.component';

describe('InsurancepolicyComponent', () => {
  let component: InsurancepolicyComponent;
  let fixture: ComponentFixture<InsurancepolicyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InsurancepolicyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InsurancepolicyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
