import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommissionNewComponent } from './commission-new.component';

describe('CommissionNewComponent', () => {
  let component: CommissionNewComponent;
  let fixture: ComponentFixture<CommissionNewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CommissionNewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CommissionNewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
