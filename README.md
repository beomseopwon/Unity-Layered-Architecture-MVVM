# Unity-Layered-Architecture-MVVM

이 프로젝트의 목표는 유니티에서 Layered Architecture와 MVVM 패턴을 사용한 View 개발에 대한 간단하고 효율적인 접근 방식을 제공 하는 것 입니다.

## 시작하기

프로젝트를 빌드 하고 실행하려면 다음과 같은 필수 구성 요소가 필요 합니다:

* [Unity 2022.3](https://unity.com/kr/releases/editor/archive) (latest LTS)

### 사용 라이브러리

프로젝트에 사용된 라이브러리 입니다:

* [R3](https://github.com/Cysharp/R3) - Reactive Programming 을 위한 라이브러리로 UniRX 의 대안
* [VContainer](https://github.com/hadashiA/VContainer) - Unity 게임 엔진을 위한 매우 빠른 DI(Dependency Injection
* [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) - Unity Editor 내부에서 실행되도록 처음부터 빌드된 NuGet 클라이언트

## 실행 및 테스트

```
Assets -> 01_Scenes -> SampleScene -> Play
```

## 폴더 구조

![](./images/scripts_hierarchy.jpg)

* 폴더는 Application, Data, Domain, Presentation로 각 계층 이름과 동일하게 구분합니다.
* 각 계층 별로 asmdef 파일을 만들어 계층간 관계성을 제한 합니다.

## 계층

![](./images/layer_group.jpg)

* 프레젠테이션 계층  : UI나 3D 개체가 포함 됩니다. 뷰는 비즈니스 로직을 실행하는 요청을 하게 됩니다. 도메인 계층에만 의존합니다.
* 도메인 계층 : 비즈니스 모델, 비즈니스 로직, 레포지토리 인터페이스가 포함됩니다.
* 데이터 계층 : 저장소(로컬, 원격) 와 데이터 소스가 포함됩니다. 도메인 계층에만 의존합니다.

## 데이터 흐름

![](./images/flow.jpg)


## License
MIT
