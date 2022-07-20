﻿[<RequireQualifiedAccess>]
module Bot.Settings

open System
open System.ComponentModel.DataAnnotations
open Microsoft.FSharp.Core

module Telegram =
  [<Literal>]
  let SectionName = "Telegram"

  [<CLIMutable>]
  type T =
    { [<Required>]
      Token: string
      [<Required>]
      BotUrl: string }

module Spotify =
  [<Literal>]
  let SectionName = "Spotify"

  [<CLIMutable>]
  type T =
    { [<Required>]
      ClientId: string
      [<Required>]
      ClientSecret: string
      [<Required>]
      CallbackUrl: Uri }

module Database =
  [<Literal>]
  let SectionName = "Database"

  [<CLIMutable>]
  type T =
    { [<Required>]
      ConnectionString: string }
