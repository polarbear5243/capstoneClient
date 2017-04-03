S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 9778
Date: 2017-04-03 03:15:14+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 9778, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002632
r2   = 0x00000006, r3   = 0xb404d4c0
r4   = 0x00000002, r5   = 0xb404d000
r6   = 0xb6a1b09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0x2a02faf0
r10  = 0xbefff8a0, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbefff42c
lr   = 0xb6911f18, pc   = 0xb6910b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    149900 KB
Buffers:     44636 KB
Cached:     328272 KB
VmPeak:      80112 KB
VmSize:      80108 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16276 KB
VmRSS:       16276 KB
VmData:      21316 KB
VmStk:         136 KB
VmExe:          72 KB
VmLib:       28492 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9778 TID = 9778
9778 9789 9797 

Maps Information
2a000000 2a012000 r-xp /opt/usr/apps/org.example.client/bin/client
2a022000 2a223000 rw-p [heap]
b2599000 b25a1000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b25b2000 b25bf000 r-xp /usr/lib/libmdm-common.so.1.0.98
b25d0000 b2611000 r-xp /usr/lib/libmdm.so.1.2.12
b2621000 b2629000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b2638000 b2648000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b2669000 b26c9000 r-xp /usr/lib/libasound.so.2.0.0
b26db000 b26de000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b26ee000 b26f1000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b2701000 b2706000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2716000 b2721000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b2735000 b273a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b274a000 b2765000 r-xp /usr/lib/libmmfsound.so.0.1.0
b2775000 b277c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b278c000 b2796000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b27a6000 b27a8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b27b8000 b27b9000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b27c9000 b27d1000 r-xp /usr/lib/libfeedback.so.0.1.4
b27f9000 b27fa000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b280a000 b281e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b297a000 b297b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b298b000 b298e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b299f000 b29a0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b29b0000 b29b2000 r-xp /usr/lib/libxcb-present.so.0.0.0
b29c2000 b29c4000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b29d4000 b29d5000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b29e7000 b29ed000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b29fd000 b2a0d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2a1d000 b2a29000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2a3b000 b323a000 rw-p [stack:9797]
b356b000 b3575000 r-xp /lib/libnss_files-2.20-2014.11.so
b3586000 b358f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b35a0000 b35b1000 r-xp /lib/libnsl-2.20-2014.11.so
b35c4000 b35ca000 r-xp /lib/libnss_compat-2.20-2014.11.so
b35db000 b35df000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f0000 b36d3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b370a000 b3732000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b3744000 b3f43000 rw-p [stack:9789]
b3f43000 b3f45000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3f55000 b4033000 r-xp /usr/lib/libCOREGL.so.4.0
b4052000 b4055000 r-xp /lib/libattr.so.1.1.0
b4066000 b406d000 r-xp /lib/libcrypt-2.20-2014.11.so
b40a5000 b40a8000 r-xp /lib/libcap.so.2.21
b40b8000 b40ba000 r-xp /usr/lib/libiri.so
b40ca000 b40ea000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b40ec000 b40ef000 r-xp /usr/lib/libuuid.so.1.3.0
b40ff000 b4116000 r-xp /usr/lib/libblkid.so.1.1.0
b4127000 b4150000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4161000 b41a8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b9000 b41bf000 r-xp /usr/lib/libjson-c.so.2.0.1
b41d1000 b41d5000 r-xp /usr/lib/libogg.so.0.7.1
b41e5000 b4207000 r-xp /usr/lib/libvorbis.so.0.4.3
b4217000 b42fb000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4317000 b4322000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4332000 b4335000 r-xp /usr/lib/libEGL.so.1.4
b4346000 b434c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b435c000 b435e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b436e000 b437b000 r-xp /usr/lib/libGLESv2.so.2.0
b438c000 b43a4000 r-xp /usr/lib/libmount.so.1.1.0
b43b6000 b43b8000 r-xp /usr/lib/libXau.so.6.0.0
b43c8000 b43fe000 r-xp /usr/lib/libpulse.so.0.16.2
b440f000 b4452000 r-xp /usr/lib/libsndfile.so.1.0.25
b4467000 b44e1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b44f6000 b44fd000 r-xp /usr/lib/libsensord-share.so
b450e000 b4570000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4585000 b4588000 r-xp /usr/lib/libXv.so.1.0.0
b4598000 b459d000 r-xp /usr/lib/libutilX.so.1.1.0
b45ad000 b45b2000 r-xp /usr/lib/libffi.so.6.0.2
b45c2000 b45d3000 r-xp /lib/libresolv-2.20-2014.11.so
b45e8000 b45ea000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b45fa000 b460f000 r-xp /lib/libexpat.so.1.5.2
b4621000 b46df000 r-xp /usr/lib/libcairo.so.2.11200.14
b46f2000 b46fa000 r-xp /usr/lib/libdrm.so.2.4.0
b470b000 b470e000 r-xp /usr/lib/libdri2.so.0.0.0
b471e000 b476c000 r-xp /usr/lib/libssl.so.1.0.0
b4781000 b478d000 r-xp /usr/lib/libeeze.so.1.13.0
b479d000 b47a6000 r-xp /usr/lib/libethumb.so.1.13.0
b47b7000 b47ba000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b47ca000 b4981000 r-xp /usr/lib/libcrypto.so.1.0.0
b576b000 b5774000 r-xp /usr/lib/libXi.so.6.1.0
b5785000 b5787000 r-xp /usr/lib/libXgesture.so.7.0.0
b5797000 b579b000 r-xp /usr/lib/libXtst.so.6.1.0
b57ab000 b57b1000 r-xp /usr/lib/libXrender.so.1.3.0
b57c1000 b57c7000 r-xp /usr/lib/libXrandr.so.2.2.0
b57d7000 b57d9000 r-xp /usr/lib/libXinerama.so.1.0.0
b57e9000 b57ec000 r-xp /usr/lib/libXfixes.so.3.1.0
b57fd000 b5808000 r-xp /usr/lib/libXext.so.6.4.0
b5818000 b581a000 r-xp /usr/lib/libXdamage.so.1.1.0
b582a000 b582c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b583c000 b5843000 r-xp /usr/lib/libXcursor.so.1.0.2
b5853000 b586b000 r-xp /usr/lib/libudev.so.1.6.0
b586e000 b5882000 r-xp /usr/lib/libxcb.so.1.1.0
b5892000 b5894000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b58a4000 b58ab000 r-xp /usr/lib/libembryo.so.1.13.0
b58bb000 b58c5000 r-xp /usr/lib/libecore_audio.so.1.13.0
b58d6000 b58ee000 r-xp /lib/libz.so.1.2.8
b58ff000 b593b000 r-xp /usr/lib/libsystemd.so.0.4.0
b593d000 b5955000 r-xp /usr/lib/libsensor.so.1.1.0
b5966000 b596d000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b597d000 b5984000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b5996000 b5998000 r-xp /usr/lib/libappsvc.so.0.1.0
b59a8000 b59ab000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b59bb000 b59d4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b59e5000 b5a1c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b5a2d000 b5b18000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b5b2b000 b5ba4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b5bb6000 b5bc0000 r-xp /usr/lib/libvconf.so.0.2.45
b5bd0000 b5bd2000 r-xp /usr/lib/libvasum.so.0.3.1
b5be2000 b5be6000 r-xp /usr/lib/libsmack.so.1.0.0
b5bf6000 b5bfb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b5c0c000 b5c36000 r-xp /usr/lib/libdbus-1.so.3.8.12
b5c47000 b5c5e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b5c6f000 b5c72000 r-xp /usr/lib/libbundle.so.0.1.22
b5c82000 b5c9a000 r-xp /usr/lib/libpng12.so.0.50.0
b5cab000 b5cce000 r-xp /usr/lib/libjpeg.so.8.0.2
b5cef000 b5d03000 r-xp /usr/lib/libector.so.1.13.0
b5d14000 b5d2c000 r-xp /usr/lib/liblua-5.1.so
b5d3d000 b5d94000 r-xp /usr/lib/libfreetype.so.6.11.3
b5da8000 b5dd0000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5de1000 b5df4000 r-xp /usr/lib/libfribidi.so.0.3.1
b5e05000 b5e3f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e50000 b5e5e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e6e000 b5e76000 r-xp /usr/lib/libtbm.so.1.0.0
b5e86000 b5e93000 r-xp /usr/lib/libeio.so.1.13.0
b5ea3000 b5ea5000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5eb5000 b5eba000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5eca000 b5ee1000 r-xp /usr/lib/libefreet.so.1.13.0
b5ef3000 b5f13000 r-xp /usr/lib/libeldbus.so.1.13.0
b5f23000 b5f43000 r-xp /usr/lib/libecore_con.so.1.13.0
b5f45000 b5f4b000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f5b000 b5f6c000 r-xp /usr/lib/libemotion.so.1.13.0
b5f7d000 b5f84000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f94000 b5fa6000 r-xp /usr/lib/libecore_input.so.1.13.0
b5fb7000 b5fbc000 r-xp /usr/lib/libecore_file.so.1.13.0
b5fcc000 b5fe5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ff5000 b6012000 r-xp /usr/lib/libeet.so.1.13.0
b602b000 b603b000 r-xp /usr/lib/libefl.so.1.13.0
b604c000 b6131000 r-xp /usr/lib/libicuuc.so.51.1
b614e000 b628e000 r-xp /usr/lib/libicui18n.so.51.1
b62a5000 b62dd000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ef000 b62f1000 r-xp /usr/lib/libttrace.so.1.1
b6301000 b63e3000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b63f4000 b64d6000 r-xp /usr/lib/libX11.so.6.3.0
b64e9000 b64f8000 r-xp /usr/lib/libeo.so.1.13.0
b6509000 b658c000 r-xp /usr/lib/libedje.so.1.13.0
b659f000 b65bd000 r-xp /usr/lib/libecore.so.1.13.0
b65dd000 b66b2000 r-xp /usr/lib/libxml2.so.2.9.2
b66c7000 b66ca000 r-xp /usr/lib/libiniparser.so.0
b66da000 b6722000 r-xp /usr/lib/libeina.so.1.13.0
b6733000 b6738000 r-xp /usr/lib/libappcore-common.so.1.1
b6748000 b674d000 r-xp /usr/lib/libappcore-efl.so.1.1
b675d000 b6762000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6773000 b6799000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b67a9000 b67c1000 r-xp /usr/lib/libaul.so.0.1.0
b67d3000 b683e000 r-xp /lib/libm-2.20-2014.11.so
b684f000 b6855000 r-xp /lib/librt-2.20-2014.11.so
b6866000 b6868000 r-xp /lib/libdl-2.20-2014.11.so
b6879000 b6886000 r-xp /usr/lib/libunwind.so.8.0.1
b68bc000 b68d5000 r-xp /lib/libgcc_s-4.9.so.1
b68e5000 b6a09000 r-xp /lib/libc-2.20-2014.11.so
b6a1e000 b6ab9000 r-xp /usr/lib/libstdc++.so.6.0.20
b6ad5000 b6c5c000 r-xp /usr/lib/libevas.so.1.13.0
b6c91000 b6ec5000 r-xp /usr/lib/libelementary.so.1.13.0
b6ef4000 b6efb000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6f0c000 b6f0e000 r-xp /usr/lib/libdlog.so.0.0.0
b6f1e000 b6f23000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6f33000 b6f37000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6f48000 b6f4a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6f5b000 b6f6f000 r-xp /lib/libpthread-2.20-2014.11.so
b6f9b000 b6fa8000 r-xp /usr/lib/liblptcp.so
b6fba000 b6fbe000 r-xp /usr/lib/libsys-assert.so
b6fcf000 b6fef000 r-xp /lib/ld-2.20-2014.11.so
befdf000 bf000000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9778)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6910b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
_text_by_locale(389) > text : 오전 3:08
04-03 03:08:00.719+0900 I/INDICATOR(  630): clock.c: getTimeFormatted(176) > "time format : 오전 3:08"
04-03 03:08:00.719+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:08"
04-03 03:08:00.719+0900 W/INDICATOR(  630): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:08:00.719+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145809716 Time: <font_size=31> </font_size> <font_size=31> 오전 3:08</font_size></font>"
04-03 03:09:00.768+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:09:00.768+0900 E/UXT     (  630): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:09
04-03 03:09:00.768+0900 I/INDICATOR(  630): clock.c: getTimeFormatted(176) > "time format : 오전 3:09"
04-03 03:09:00.768+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:09"
04-03 03:09:00.768+0900 W/INDICATOR(  630): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:09:00.768+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145807664 Time: <font_size=31> </font_size> <font_size=31> 오전 3:09</font_size></font>"
04-03 03:10:00.766+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:10:00.766+0900 E/UXT     (  630): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:10
04-03 03:10:00.766+0900 I/INDICATOR(  630): clock.c: getTimeFormatted(176) > "time format : 오전 3:10"
04-03 03:10:00.766+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:10"
04-03 03:10:00.766+0900 W/INDICATOR(  630): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:10:00.766+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145793300 Time: <font_size=31> </font_size> <font_size=31> 오전 3:10</font_size></font>"
04-03 03:10:30.685+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:30.685+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:30.685+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:30.685+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:30.695+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:10:30.695+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:10:30.695+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:10:30.695+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:30.695+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:30.695+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:30.695+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:10:30.695+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:10:51.165+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:11:00.775+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:11:00.775+0900 E/UXT     (  630): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:11
04-03 03:11:00.775+0900 I/INDICATOR(  630): clock.c: getTimeFormatted(176) > "time format : 오전 3:11"
04-03 03:11:00.775+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:11"
04-03 03:11:00.775+0900 W/INDICATOR(  630): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:11:00.775+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145742000 Time: <font_size=31> </font_size> <font_size=31> 오전 3:11</font_size></font>"
04-03 03:11:16.780+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:11:16.780+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:42.365+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:11:42.375+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:11:42.375+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:12:00.773+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:12:00.783+0900 E/UXT     (  630): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:12
04-03 03:12:00.783+0900 I/INDICATOR(  630): clock.c: getTimeFormatted(176) > "time format : 오전 3:12"
04-03 03:12:00.783+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:12"
04-03 03:12:00.783+0900 W/INDICATOR(  630): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:12:00.783+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145676336 Time: <font_size=31> </font_size> <font_size=31> 오전 3:12</font_size></font>"
04-03 03:13:00.792+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:13:00.792+0900 E/UXT     (  630): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:13
04-03 03:13:00.792+0900 I/INDICATOR(  630): clock.c: getTimeFormatted(176) > "time format : 오전 3:13"
04-03 03:13:00.792+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:13"
04-03 03:13:00.792+0900 W/INDICATOR(  630): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:13:00.792+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145666076 Time: <font_size=31> </font_size> <font_size=31> 오전 3:13</font_size></font>"
04-03 03:13:39.600+0900 E/PKGMGR_SERVER( 9403): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:13:39.650+0900 E/PKGMGR  ( 9401): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-03 03:13:39.690+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 14
04-03 03:13:39.690+0900 E/AUL_AMD (  611): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 9299
04-03 03:13:39.700+0900 W/AUL_AMD (  611): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-03 03:13:39.700+0900 E/PKGMGR_SERVER( 9403): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9406]
04-03 03:13:41.752+0900 E/PKGMGR_SERVER( 9403): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:13:41.752+0900 E/PKGMGR_SERVER( 9403): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:13:43.593+0900 E/PKGMGR  ( 9492): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-03 03:13:43.674+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:13:43.714+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-03 03:13:43.724+0900 E/PKGMGR_SERVER( 9494): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-03 03:13:43.734+0900 E/PKGMGR  ( 9492): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[94920002]
04-03 03:13:43.894+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:43.894+0900 W/AUL_AMD (  611): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-03 03:13:43.894+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:43.894+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-03 03:13:43.894+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-03 03:13:43.904+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:13:43.904+0900 I/Tizen::App( 1235): (119) > InstallationInProgress [30]
04-03 03:13:43.904+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-03 03:13:43.904+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:43.904+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:44.044+0900 W/CERT_SVC_VCORE( 9497): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:13:44.114+0900 E/rpm-installer( 9497): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-03 03:13:44.114+0900 E/rpm-installer( 9497): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-03 03:13:44.164+0900 E/PKGMGR_PARSER( 9497): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-03 03:13:44.184+0900 I/PRIVACY-MANAGER-CLIENT( 9497): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:13:44.184+0900 I/PRIVACY-MANAGER-CLIENT( 9497): SocketClient.cpp: connect(62) > Client connected
04-03 03:13:44.184+0900 I/PRIVACY-MANAGER-SERVER(  925): SocketService.cpp: mainloop(230) > Got incoming connection
04-03 03:13:44.184+0900 I/PRIVACY-MANAGER-CLIENT( 9497): SocketClient.cpp: disconnect(72) > Client disconnected
04-03 03:13:44.194+0900 E/PKGMGR_CERT( 9497): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-03 03:13:44.194+0900 E/PKGMGR_CERT( 9497): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-03 03:13:44.204+0900 E/PKGMGR_CERT( 9497): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-03 03:13:44.234+0900 E/rpm-installer( 9497): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-03 03:13:44.234+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:44.234+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:44.234+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-03 03:13:44.234+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-03 03:13:44.234+0900 E/ESD     (  887): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-03 03:13:44.244+0900 W/AUL_AMD (  611): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-03 03:13:44.244+0900 W/ISF_PANEL_EFL(  672): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-03 03:13:44.254+0900 W/ISF_PANEL_EFL(  672): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-03 03:13:44.304+0900 E/EFL     ( 6120): ecore_x<6120> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=9813435
04-03 03:13:44.304+0900 E/EFL     ( 6120): ecore_x<6120> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=9813549
04-03 03:13:44.304+0900 I/PHONE   ( 6120): CtTabView.cpp: onPop(233) > [0;34m>>>HIT<<<[0;m
04-03 03:13:44.304+0900 I/PHONE   ( 6120): PhDialerView.cpp: onTabPop(161) > [0;34m>>>HIT<<<[0;m
04-03 03:13:44.304+0900 I/PHONE   ( 6120): PhDialerView.cpp: __getInputFieldControl(362) > [0;34m>>>HIT<<<[0;m
04-03 03:13:44.304+0900 E/PHONE   ( 6120): PhDialerInputFieldControl.cpp: clearText(539) > [0;31m* Critical * nothing to remove[0;m
04-03 03:13:44.304+0900 I/PHONE   ( 6120): PhLogMainListView.cpp: onTabPop(543) > [0;34m>>>HIT<<<[0;m
04-03 03:13:44.304+0900 I/PHONE   ( 6120): CtListView.cpp: onTabPop(1485) > [0;34m>>>HIT<<<[0;m
04-03 03:13:44.304+0900 I/PHONE   ( 6120): CtListView.cpp: __cleanSearchbar(2271) > [0;34m>>>HIT<<<[0;m
04-03 03:13:44.304+0900 E/EFL     ( 6120): <6120> elm_main.c:1298 elm_object_part_content_get() safety check failed: obj == NULL
04-03 03:13:44.304+0900 E/PHONE   ( 6120): CtListView.cpp: __clearGalSearchItems(4921) > [0;31m* Critical * __genlist is NULL[0;m
04-03 03:13:44.304+0900 I/WAPP    ( 6120): WNaviframe.cpp: onLastItemPop(252) > [0;34m>>>HIT<<<[0;m
04-03 03:13:44.304+0900 W/AUL_AMD (  611): amd_launch.c: __e17_status_handler(3328) > pid(862) status(3)
04-03 03:13:44.304+0900 W/AUL_AMD (  611): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 03:13:44.304+0900 W/AUL_AMD (  611): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-03 03:13:44.304+0900 W/AUL     (  611): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(862)
04-03 03:13:44.304+0900 W/AUL     (  611): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 862, appid: com.samsung.homescreen, status: fg
04-03 03:13:44.304+0900 E/IV-COMMON(  862): QuramBitmapFactory.cpp: getFileSize(163) > [F:getFileSize	L:163] getFileSize : file open fail
04-03 03:13:44.314+0900 W/HOME_APPS(  862): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[2]
04-03 03:13:44.324+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 36
04-03 03:13:44.334+0900 W/AUL_AMD (  611): amd_launch.c: __e17_status_handler(3328) > pid(862) status(0)
04-03 03:13:44.354+0900 E/EFL     (  337): eo<337> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-03 03:13:44.354+0900 E/EFL     (  337): eo<337> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-03 03:13:44.364+0900 I/APP_CORE( 6120): appcore-efl.c: __do_app(514) > [APP 6120] Event: PAUSE State: RUNNING
04-03 03:13:44.364+0900 I/APP_CORE(  862): appcore-efl.c: __do_app(514) > [APP 862] Event: RESUME State: PAUSED
04-03 03:13:44.364+0900 I/CAPI_APPFW_APPLICATION(  862): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-03 03:13:44.364+0900 I/CAPI_APPFW_APPLICATION( 6120): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-03 03:13:44.364+0900 I/WAPP    ( 6120): WApp.cpp: __onPause(79) > [0;34m>>>HIT<<<[0;m
04-03 03:13:44.364+0900 I/PHONE   ( 6120): ContactsApp.cpp: onPause(73) > [0;34m>>>HIT<<<[0;m
04-03 03:13:44.364+0900 E/cluster-home(  862): homescreen.cpp: OnResume(233) >  app resume
04-03 03:13:44.364+0900 W/UI_GADGET( 6120): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
04-03 03:13:44.364+0900 I/Tizen::System( 1235): (259) > Active app [com.samsun], current [com.samsun] 
04-03 03:13:44.364+0900 I/Tizen::System( 1235): (273) > Current App[com.samsun] is already actived.
04-03 03:13:44.374+0900 W/AUL_AMD (  611): amd_launch.c: __e17_status_handler(3328) > pid(6120) status(4)
04-03 03:13:44.374+0900 W/AUL     (  611): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.contacts(6120)
04-03 03:13:44.374+0900 W/AUL     (  611): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6120, appid: com.samsung.contacts, status: bg
04-03 03:13:44.394+0900 E/weather-widget( 1305): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-03 03:13:44.414+0900 E/weather-widget( 1305): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-03 03:13:44.434+0900 I/TIZEN_N_SOUND_MANAGER(  918): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-03 03:13:44.434+0900 E/TIZEN_N_SOUND_MANAGER(  918): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-03 03:13:44.434+0900 E/weather-common( 1305): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-03 03:13:44.444+0900 I/TIZEN_N_SOUND_MANAGER(  918): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-03 03:13:44.444+0900 E/TIZEN_N_SOUND_MANAGER(  918): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-03 03:13:44.444+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 6120): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 80
04-03 03:13:44.444+0900 E/APP_CORE( 6120): appcore-efl.c: _capture_and_make_file(1619) > win[7600003] widget[720] height[1280]
04-03 03:13:44.444+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 15
04-03 03:13:44.464+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 33
04-03 03:13:44.534+0900 I/CAPI_NETWORK_CONNECTION( 1305): connection.c: connection_create(409) > New handle created[0xb8e5e7b8]
04-03 03:13:44.534+0900 I/CAPI_NETWORK_CONNECTION( 1305): connection.c: connection_get_type(463) > Connected Network = 2
04-03 03:13:44.534+0900 I/CAPI_NETWORK_CONNECTION( 1305): connection.c: connection_destroy(427) > Destroy handle: 0xb8e5e7b8
04-03 03:13:44.534+0900 E/weather-common( 1305): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-03 03:13:44.544+0900 E/weather-widget( 1305): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-03 03:13:44.544+0900 I/CAPI_WIDGET_APPLICATION( 1305): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-03 03:13:44.544+0900 I/CAPI_WIDGET_APPLICATION( 1305): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-03 03:13:44.544+0900 W/AUL     ( 1305): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1305, appid: com.samsung.weather-m-widget, status: fg
04-03 03:13:45.756+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:13:46.176+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9497]
04-03 03:13:47.087+0900 E/PKGMGR  ( 9547): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-03 03:13:47.117+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-03 03:13:47.127+0900 E/PKGMGR_INFO( 9494): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-03 03:13:47.137+0900 E/rpm-installer( 9494): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-03 03:13:47.147+0900 E/PKGMGR_SERVER( 9494): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-03 03:13:47.147+0900 E/PKGMGR  ( 9547): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[95470002]
04-03 03:13:47.267+0900 E/PKGMGR_INSTALLER( 9549): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-03 03:13:47.267+0900 E/rpm-installer( 9549): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-03 03:13:47.277+0900 E/rpm-installer( 9549): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-03 03:13:47.277+0900 E/rpm-installer( 9549): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-03 03:13:47.277+0900 E/rpm-installer( 9549): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:13:47.287+0900 E/rpm-installer( 9549): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-03 03:13:47.287+0900 E/rpm-installer( 9549): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:13:47.337+0900 W/CERT_SVC_VCORE( 9549): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-03 03:13:47.387+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:47.387+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-03 03:13:47.387+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:47.387+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-03 03:13:47.397+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:47.397+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:47.397+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-03 03:13:47.397+0900 I/Tizen::App( 1235): (119) > InstallationInProgress [30]
04-03 03:13:47.397+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-03 03:13:47.577+0900 E/rpm-installer( 9549): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-03 03:13:47.577+0900 E/rpm-installer( 9549): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-03 03:13:47.577+0900 E/rpm-installer( 9549): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-03 03:13:47.577+0900 E/rpm-installer( 9549): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-03 03:13:47.577+0900 E/rpm-installer( 9549): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-03 03:13:47.577+0900 E/rpm-installer( 9549): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-03 03:13:47.587+0900 E/PKGMGR_PARSER( 9549): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-03 03:13:47.587+0900 E/PKGMGR_PARSER( 9549): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-03 03:13:47.627+0900 I/PRIVACY-MANAGER-CLIENT( 9549): SocketClient.cpp: SocketClient(37) > Client created
04-03 03:13:47.758+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:13:47.838+0900 E/PKGMGR_PARSER( 9549): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-03 03:13:47.848+0900 E/PKGMGR_CERT( 9549): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-03 03:13:47.858+0900 E/PKGMGR_CERT( 9549): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-03 03:13:47.858+0900 E/PKGMGR_CERT( 9549): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-03 03:13:47.858+0900 E/PKGMGR_CERT( 9549): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-03 03:13:47.858+0900 E/PKGMGR_CERT( 9549): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-03 03:13:47.858+0900 E/PKGMGR_CERT( 9549): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-03 03:13:47.858+0900 E/PKGMGR_CERT( 9549): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-03 03:13:47.858+0900 E/PKGMGR_CERT( 9549): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-03 03:13:47.868+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:47.868+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:47.868+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-03 03:13:47.868+0900 I/Tizen::App( 1235): (119) > InstallationInProgress [60]
04-03 03:13:47.868+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-03 03:13:47.888+0900 E/rpm-installer( 9549): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-03 03:13:47.908+0900 E/rpm-installer( 9549): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-03 03:13:47.908+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:47.908+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:47.908+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-03 03:13:47.908+0900 I/Tizen::App( 1235): (119) > InstallationInProgress [100]
04-03 03:13:47.908+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-03 03:13:49.399+0900 I/APP_CORE( 6120): appcore-efl.c: __do_app(514) > [APP 6120] Event: MEM_FLUSH State: PAUSED
04-03 03:13:49.760+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-03 03:13:49.790+0900 I/Tizen::App( 1235): (1894) > PackageEventHandler - req: 12350002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-03 03:13:49.790+0900 I/Tizen::App( 1235): (78) > Installation is Completed. [Package = org.example.client]
04-03 03:13:49.790+0900 I/Tizen::App( 1235): (671) > Enter. package(org.example.client), installationResult(0)
04-03 03:13:49.790+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-03 03:13:49.790+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-03 03:13:49.790+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-03 03:13:49.790+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:49.790+0900 E/PKGMGR  ( 1487): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-03 03:13:49.800+0900 I/Tizen::App( 1235): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-03 03:13:49.820+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-03 03:13:49.820+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-03 03:13:49.820+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-03 03:13:49.820+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-03 03:13:49.820+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-03 03:13:49.820+0900 I/Tizen::App( 1235): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-03 03:13:49.830+0900 I/Tizen::App( 1235): (416) > appName = [client]
04-03 03:13:49.830+0900 I/Tizen::App( 1235): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:13:49.830+0900 E/PKGMGR_INFO( 1235): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-03 03:13:49.830+0900 I/Tizen::App( 1235): (683) > Application count(1) in this package
04-03 03:13:49.840+0900 I/Tizen::App( 1235): (840) > Enter.
04-03 03:13:49.840+0900 I/Tizen::App( 1235): (703) > Exit.
04-03 03:13:49.840+0900 I/Tizen::App( 1235): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-03 03:13:49.840+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-03 03:13:49.840+0900 E/HOME_APPS(  862): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-03 03:13:49.840+0900 E/cluster-home(  862): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-03 03:13:49.840+0900 W/HOME_APPS(  862): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-03 03:13:49.850+0900 W/ISF_PANEL_EFL(  672): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-03 03:13:49.850+0900 I/Tizen::App( 1235): (416) > appName = [client]
04-03 03:13:49.850+0900 I/Tizen::App( 1235): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-03 03:13:49.850+0900 I/Tizen::App( 1235): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-03 03:13:49.850+0900 I/Tizen::App( 1235): (131) > Enter
04-03 03:13:49.850+0900 I/Tizen::App( 1235): (137) > org.example.client does not have launch condition
04-03 03:13:49.850+0900 I/Tizen::App( 1235): (883) > Exit.
04-03 03:13:49.860+0900 E/RESOURCED(  634): procfs.c: proc_get_oom_score_adj(131) > fopen /proc/9549/oom_score_adj failed
04-03 03:13:49.860+0900 E/RESOURCED(  634): proc-main.c: resourced_proc_status_change(867) > Empty pid or process not exists. 9549
04-03 03:13:49.860+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9549]
04-03 03:13:49.870+0900 E/util-view(  862): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-03 03:13:49.890+0900 W/HOME_APPS(  862): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-03 03:13:51.751+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:13:51.751+0900 E/PKGMGR_SERVER( 9494): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:13:54.134+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-03 03:13:54.134+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 03:13:54.144+0900 I/AUL     (  611): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-03 03:13:54.154+0900 I/AUL     (  611): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-03 03:13:54.154+0900 E/AUL_AMD (  611): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-03 03:13:54.154+0900 W/AUL_AMD (  611): amd_launch.c: _start_app(2508) > caller pid : 9607
04-03 03:13:54.154+0900 E/AUL_AMD (  611): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-03 03:13:54.154+0900 E/RESOURCED(  634): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-03 03:13:54.164+0900 E/RESOURCED(  634): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 03:13:54.164+0900 W/AUL_AMD (  611): amd_launch.c: _start_app(3052) > pad pid(-4)
04-03 03:13:54.274+0900 W/AUL     (  611): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9609, appid: org.example.client
04-03 03:13:54.274+0900 E/AUL     (  611): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-03 03:13:54.294+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9609)
04-03 03:13:55.285+0900 W/AUL_AMD (  611): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 03:13:55.285+0900 W/AUL_AMD (  611): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-03 03:13:57.267+0900 I/abc     ( 9609): abc
04-03 03:13:57.277+0900 I/CAPI_APPFW_APPLICATION( 9609): app_main.c: ui_app_main(789) > app_efl_main
04-03 03:13:58.428+0900 I/CAPI_APPFW_APPLICATION( 9609): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-03 03:13:59.289+0900 W/AUL     (  611): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(9609)
04-03 03:13:59.289+0900 W/AUL     (  611): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9609, appid: org.example.client, status: bg
04-03 03:14:00.580+0900 E/TBM     ( 9609): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 03:14:00.800+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:14:00.800+0900 E/UXT     (  630): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:14
04-03 03:14:00.800+0900 I/INDICATOR(  630): clock.c: getTimeFormatted(176) > "time format : 오전 3:14"
04-03 03:14:00.800+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:14"
04-03 03:14:00.800+0900 W/INDICATOR(  630): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:14:00.800+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145647606 Time: <font_size=31> </font_size> <font_size=31> 오전 3:14</font_size></font>"
04-03 03:14:05.745+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:05.745+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:05.745+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:05.745+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:05.765+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:05.765+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:05.765+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:14:05.765+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:05.765+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:05.765+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:05.785+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:05.785+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:11.941+0900 W/CRASH_MANAGER( 9632): worker.c: worker_job(1199) > 0609609636c691491156851
04-03 03:14:13.403+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:13.403+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:13.403+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:13.403+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:13.403+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:13.403+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:13.403+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:14:13.403+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:13.403+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:13.403+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:13.413+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:13.413+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:15.965+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:18.538+0900 E/INDICATOR(  630): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-03 03:14:45.934+0900 E/PKGMGR_SERVER( 9719): pkgmgr-server.c: main(2414) > package manager server start
04-03 03:14:45.984+0900 E/PKGMGR  ( 9717): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-03 03:14:46.024+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 14
04-03 03:14:46.024+0900 E/AUL_AMD (  611): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 9609
04-03 03:14:46.034+0900 W/AUL_AMD (  611): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-03 03:14:46.044+0900 E/PKGMGR_SERVER( 9719): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9722]
04-03 03:14:47.756+0900 E/PKGMGR_SERVER( 9719): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-03 03:14:47.756+0900 E/PKGMGR_SERVER( 9719): pkgmgr-server.c: main(2471) > package manager server terminated.
04-03 03:14:48.457+0900 W/AUL     ( 9776): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-03 03:14:48.457+0900 W/AUL_AMD (  611): amd_request.c: __request_handler(906) > __request_handler: 0
04-03 03:14:48.467+0900 I/AUL     (  611): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-03 03:14:48.467+0900 I/AUL     (  611): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-03 03:14:48.467+0900 E/AUL_AMD (  611): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-03 03:14:48.467+0900 W/AUL_AMD (  611): amd_launch.c: _start_app(2508) > caller pid : 9776
04-03 03:14:48.467+0900 E/AUL_AMD (  611): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-03 03:14:48.477+0900 E/RESOURCED(  634): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-03 03:14:48.477+0900 E/RESOURCED(  634): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-03 03:14:48.477+0900 W/AUL_AMD (  611): amd_launch.c: _start_app(3052) > pad pid(-4)
04-03 03:14:48.597+0900 W/AUL     (  611): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9778, appid: org.example.client
04-03 03:14:48.597+0900 E/AUL     (  611): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-03 03:14:48.617+0900 W/AUL     ( 9776): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9778)
04-03 03:14:49.598+0900 W/AUL_AMD (  611): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-03 03:14:49.598+0900 W/AUL_AMD (  611): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-03 03:14:52.281+0900 I/abc     ( 9778): abc
04-03 03:14:52.301+0900 I/CAPI_APPFW_APPLICATION( 9778): app_main.c: ui_app_main(789) > app_efl_main
04-03 03:14:53.602+0900 W/AUL     (  611): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(9778)
04-03 03:14:53.602+0900 W/AUL     (  611): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9778, appid: org.example.client, status: bg
04-03 03:14:53.672+0900 I/CAPI_APPFW_APPLICATION( 9778): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-03 03:14:55.834+0900 E/TBM     ( 9778): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-03 03:15:00.809+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(195) > ""
04-03 03:15:00.809+0900 E/UXT     (  630): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:15
04-03 03:15:00.809+0900 I/INDICATOR(  630): clock.c: getTimeFormatted(176) > "time format : 오전 3:15"
04-03 03:15:00.809+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:15"
04-03 03:15:00.809+0900 W/INDICATOR(  630): clock.c: indicator_clock_changed_cb(272) > 
04-03 03:15:00.809+0900 I/INDICATOR(  630): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145549110 Time: <font_size=31> </font_size> <font_size=31> 오전 3:15</font_size></font>"
04-03 03:15:15.013+0900 W/CRASH_MANAGER( 9800): worker.c: worker_job(1199) > 0609778636c69149115691
