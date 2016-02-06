#define __int8 char
#define __int16 short
#define __int32 int
#define __int64 long long

struct _SCOPETABLE_ENTRY;

/* 1 */
typedef struct _SCOPETABLE_ENTRY *PSCOPETABLE_ENTRY;

/* 2 */
struct _EH3_EXCEPTION_REGISTRATION
{
  struct _EH3_EXCEPTION_REGISTRATION *Next;
  PVOID ExceptionHandler;
  PSCOPETABLE_ENTRY ScopeTable;
  DWORD TryLevel;
};

/* 3 */
typedef struct _EH3_EXCEPTION_REGISTRATION EH3_EXCEPTION_REGISTRATION;

/* 4 */
typedef struct _EH3_EXCEPTION_REGISTRATION *PEH3_EXCEPTION_REGISTRATION;

/* 5 */
struct CPPEH_RECORD
{
  DWORD old_esp;
  EXCEPTION_POINTERS *exc_ptr;
  struct _EH3_EXCEPTION_REGISTRATION registration;
};

/* 6 */
struct _SCOPETABLE_ENTRY
{
  int EnclosingLevel;
  void *FilterFunc;
  void *HandlerFunc;
};

/* 7 */
struct Concurrency::details::SchedulerBase;

/* 8 */
struct Concurrency::details::SchedulerProxy;

/* 9 */
struct std::_Ref_count_base;

/* 10 */
struct Concurrency::details::_ReaderWriterLock;

/* 11 */
struct Concurrency::details::UMSThreadVirtualProcessor;

/* 12 */
struct Concurrency::details::SchedulingRing;

/* 13 */
struct DNameNode;

/* 14 */
struct stdiobuf;

/* 15 */
struct Concurrency::details::SchedulerNode;

/* 16 */
struct Concurrency::details::InternalContextBase;

/* 17 */
struct Concurrency::details::ExternalContextBase;

/* 18 */
struct Concurrency::details::_NonReentrantLock;

/* 19 */
struct std::_Timevec;

/* 20 */
struct Concurrency::details::UMSFreeVirtualProcessorRoot::InitialThreadParam;

/* 21 */
struct std::strstreambuf;

/* 22 */
struct std::locale::_Locimp;

/* 23 */
struct std::ios_base;

/* 24 */
#pragma pack(push, 1)
struct _msExcept7
{
  int Magic;
  int Count;
  void *InfoPtr;
  int CountDtr;
  void *DtrPtr;
  int _unk[2];
};
#pragma pack(pop)

/* 25 */
#pragma pack(push, 1)
struct _msExcInfo
{
  int Id;
  void *Proc;
};
#pragma pack(pop)

/* 26 */
#pragma pack(push, 1)
struct _msExcExt
{
  int _unk[3];
  int Count;
  void *RttiBlkPtr;
};
#pragma pack(pop)

/* 27 */
#pragma pack(push, 1)
struct _msRttiDscr
{
  int _unk;
  void *RttiPtr;
  int spoff;
  void *Dtr;
};
#pragma pack(pop)

