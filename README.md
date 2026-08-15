<p align="right">
  <b>English</b> · <a href="./README_RU.md">Русский</a>
</p>

# Prime Number Explorer

Academic algorithms project for finding and browsing prime numbers around a user-specified large integer using `BigInteger` arithmetic and a Miller-style strong probable-prime test.

The project combines the primality-testing algorithm with a Windows Forms interface that displays a 10×10 page of nearby primes and allows navigation to adjacent pages.

## Tech

C# · .NET · `BigInteger` · modular exponentiation · primality testing · Windows Forms

## Algorithm

The core implementation:

1. represents `n - 1` as `2^s · t` with odd `t`;
2. evaluates a fixed set of small prime bases using `BigInteger.ModPow`;
3. applies repeated modular squaring in the Miller strong probable-prime test;
4. searches to the left and right of a target value until enough primes are collected;
5. supports incremental navigation between neighboring pages of primes.

The application is designed around inputs up to `10^36`, which is also the range enforced by the UI.

## Repository structure

- `MillersDeterminateAlgorythm/Algorythm.cs` — primality testing and prime-page generation;
- `PrimeNumbersList/` — Windows Forms application and 10×10 prime-number browser;
- `PrimeNumbersList.sln` — Visual Studio solution.

## Correctness note

This repository preserves the original academic implementation. Its fixed-base Miller test and floating-point perfect-power pre-check are part of that historical code. For a production-grade primality library, those components should be replaced by a formally bounded deterministic witness set for the exact integer range and an integer-only perfect-power check.

## Project context

The value of the project is primarily algorithmic: modular arithmetic, large integers, primality testing, and building an interactive application around the algorithm. It is not intended to replace a modern cryptographic number-theory library.
