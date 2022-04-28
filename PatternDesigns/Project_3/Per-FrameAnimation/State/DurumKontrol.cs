using System;

namespace PerFrameAnimation.Satate
{
  public class DurumKontrol 
  {
  private Durum  durum;
 
  public DurumKontrol() {
    durum = new SomutDurum();
  }
 
  public void Methodum1() {
    durum.Methodum1();
  }
 
  public void Methodum2() {
    durum.Methodum2();
  }
 
  public void durumDeğiştir(Durum durum) {
    this.durum = durum;
  }
  }
}