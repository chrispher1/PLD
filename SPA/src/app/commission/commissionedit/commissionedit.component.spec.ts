import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommissioneditComponent } from './commissionedit.component';

describe('CommissioneditComponent', () => {
  let component: CommissioneditComponent;
  let fixture: ComponentFixture<CommissioneditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CommissioneditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CommissioneditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
