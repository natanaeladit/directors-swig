// file: example.h
#include <iostream>

class Base {
public:
  virtual ~Base() {}

  virtual unsigned int UIntMethod(unsigned int x) {
    std::cout << "Base - UIntMethod(" << x << ")" << std::endl;
    return x;
  }
  virtual void BaseBoolMethod(const Base &b, bool flag) {}
};

class Caller {
public:
  Caller(): m_base(0) {}
  ~Caller() { delBase(); }
  void set(Base *b) { delBase(); m_base = b; }
  void reset() { m_base = 0; }
  unsigned int UIntMethodCall(unsigned int x) { return m_base->UIntMethod(x); }

private:
  Base *m_base;
  void delBase() { delete m_base; m_base = 0; }
};