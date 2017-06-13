S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 20283
Date: 2017-06-13 14:18:32+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 20283, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00004f3b
r2   = 0x00000006, r3   = 0xb40964c0
r4   = 0x00000002, r5   = 0xb4096000
r6   = 0xb679009c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb8d67868
r10  = 0xbeb08498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbeb080ec
lr   = 0xb6686f18, pc   = 0xb6685b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     52072 KB
Buffers:     66324 KB
Cached:     240712 KB
VmPeak:      90468 KB
VmSize:      90464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19620 KB
VmRSS:       19620 KB
VmData:      22012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 20283 TID = 20283
20283 20292 20777 

Maps Information
b1b5f000 b1b67000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b78000 b1b79000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b89000 b1b9d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bb1000 b1bb2000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bc2000 b1bc5000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bd6000 b1bd7000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1be7000 b1be9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bf9000 b1bfb000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c0b000 b1c1b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c2b000 b1c37000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c49000 b2448000 rw-p [stack:20777]
b2779000 b2780000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2793000 b2799000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27a9000 b27d9000 r-xp /opt/usr/apps/org.example.client/bin/client
b2922000 b2a05000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a3c000 b2a64000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a76000 b3275000 rw-p [stack:20292]
b3275000 b3277000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3287000 b3291000 r-xp /lib/libnss_files-2.20-2014.11.so
b32a2000 b32ab000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32bc000 b32cd000 r-xp /lib/libnsl-2.20-2014.11.so
b32e0000 b32e6000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32f7000 b32f8000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3320000 b3327000 r-xp /usr/lib/libminizip.so.1.0.0
b3337000 b333c000 r-xp /usr/lib/libstorage.so.0.1
b334c000 b33ab000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33c1000 b33d5000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e5000 b3429000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3439000 b3441000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3451000 b3481000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3494000 b354d000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3561000 b35b4000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35c5000 b35e0000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35f0000 b36b1000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36c4000 b36d4000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36e4000 b36f1000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3702000 b3709000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3719000 b375a000 r-xp /usr/lib/libmdm.so.1.2.12
b376a000 b3772000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3781000 b3791000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37b2000 b3812000 r-xp /usr/lib/libasound.so.2.0.0
b3824000 b3827000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3837000 b383a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b384a000 b384f000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b385f000 b3860000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3870000 b387b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b388f000 b3896000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38a6000 b38ac000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38bc000 b38c1000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38d1000 b38ec000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38fc000 b3903000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3913000 b3916000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3927000 b3955000 r-xp /usr/lib/libidn.so.11.5.44
b3965000 b397b000 r-xp /usr/lib/libnghttp2.so.5.4.0
b398c000 b3996000 r-xp /usr/lib/libcares.so.2.1.0
b39a6000 b39b0000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39c0000 b39c2000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39d2000 b39d3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39e3000 b39e7000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39f8000 b3a20000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a31000 b3a5a000 r-xp /usr/lib/libturbojpeg.so
b3a7a000 b3a80000 r-xp /usr/lib/libgif.so.4.1.6
b3a90000 b3ad6000 r-xp /usr/lib/libcurl.so.4.3.0
b3ae7000 b3b08000 r-xp /usr/lib/libexif.so.12.3.3
b3b23000 b3b38000 r-xp /usr/lib/libtts.so
b3b49000 b3b51000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b61000 b3c27000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c47000 b3d3f000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d5e000 b3e2c000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e43000 b3e45000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e55000 b3e5b000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e6b000 b3e8e000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e9f000 b3ea1000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eb1000 b3eb3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ec4000 b3ec9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ee0000 b3ee2000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ef2000 b3ef9000 r-xp /usr/lib/libsensord-share.so
b3f09000 b3f21000 r-xp /usr/lib/libsensor.so.1.1.0
b3f32000 b3f35000 r-xp /usr/lib/libXv.so.1.0.0
b3f45000 b3f4a000 r-xp /usr/lib/libutilX.so.1.1.0
b3f5a000 b3f5f000 r-xp /usr/lib/libappcore-common.so.1.1
b3f6f000 b3f76000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f89000 b3f8d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f9e000 b407c000 r-xp /usr/lib/libCOREGL.so.4.0
b409c000 b409f000 r-xp /usr/lib/libuuid.so.1.3.0
b40af000 b40c6000 r-xp /usr/lib/libblkid.so.1.1.0
b40d7000 b40d9000 r-xp /usr/lib/libXau.so.6.0.0
b40e9000 b4130000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4142000 b4148000 r-xp /usr/lib/libjson-c.so.2.0.1
b4159000 b415d000 r-xp /usr/lib/libogg.so.0.7.1
b416d000 b418f000 r-xp /usr/lib/libvorbis.so.0.4.3
b419f000 b4283000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b429f000 b42a2000 r-xp /usr/lib/libEGL.so.1.4
b42b3000 b42b9000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42c9000 b42cb000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42db000 b42e8000 r-xp /usr/lib/libGLESv2.so.2.0
b42f9000 b435b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4370000 b4388000 r-xp /usr/lib/libmount.so.1.1.0
b439a000 b43ae000 r-xp /usr/lib/libxcb.so.1.1.0
b43be000 b43c5000 r-xp /lib/libcrypt-2.20-2014.11.so
b43fd000 b43ff000 r-xp /usr/lib/libiri.so
b440f000 b441a000 r-xp /usr/lib/libgpg-error.so.0.15.0
b442b000 b4461000 r-xp /usr/lib/libpulse.so.0.16.2
b4472000 b44b5000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ca000 b44df000 r-xp /lib/libexpat.so.1.5.2
b44f1000 b45af000 r-xp /usr/lib/libcairo.so.2.11200.14
b45c3000 b45cb000 r-xp /usr/lib/libdrm.so.2.4.0
b45db000 b45de000 r-xp /usr/lib/libdri2.so.0.0.0
b45ee000 b463c000 r-xp /usr/lib/libssl.so.1.0.0
b4651000 b465d000 r-xp /usr/lib/libeeze.so.1.13.0
b466e000 b4677000 r-xp /usr/lib/libethumb.so.1.13.0
b4687000 b468a000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b469a000 b4851000 r-xp /usr/lib/libcrypto.so.1.0.0
b563c000 b5645000 r-xp /usr/lib/libXi.so.6.1.0
b5655000 b5657000 r-xp /usr/lib/libXgesture.so.7.0.0
b5667000 b566b000 r-xp /usr/lib/libXtst.so.6.1.0
b567b000 b5681000 r-xp /usr/lib/libXrender.so.1.3.0
b5691000 b5697000 r-xp /usr/lib/libXrandr.so.2.2.0
b56a7000 b56a9000 r-xp /usr/lib/libXinerama.so.1.0.0
b56ba000 b56bd000 r-xp /usr/lib/libXfixes.so.3.1.0
b56cd000 b56d8000 r-xp /usr/lib/libXext.so.6.4.0
b56e8000 b56ea000 r-xp /usr/lib/libXdamage.so.1.1.0
b56fa000 b56fc000 r-xp /usr/lib/libXcomposite.so.1.0.0
b570c000 b57ee000 r-xp /usr/lib/libX11.so.6.3.0
b5802000 b5809000 r-xp /usr/lib/libXcursor.so.1.0.2
b5819000 b5831000 r-xp /usr/lib/libudev.so.1.6.0
b5833000 b5836000 r-xp /lib/libattr.so.1.1.0
b5846000 b5866000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5867000 b586c000 r-xp /usr/lib/libffi.so.6.0.2
b587d000 b5895000 r-xp /lib/libz.so.1.2.8
b58a5000 b58a7000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b7000 b598c000 r-xp /usr/lib/libxml2.so.2.9.2
b59a1000 b5a3c000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a58000 b5a5b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a6b000 b5a84000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a95000 b5aa6000 r-xp /lib/libresolv-2.20-2014.11.so
b5aba000 b5b34000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b49000 b5b4b000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b5b000 b5b62000 r-xp /usr/lib/libembryo.so.1.13.0
b5b72000 b5b7c000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b8d000 b5ba5000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb6000 b5bd9000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bfa000 b5c0e000 r-xp /usr/lib/libector.so.1.13.0
b5c1f000 b5c37000 r-xp /usr/lib/liblua-5.1.so
b5c48000 b5c9f000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cb3000 b5cdb000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cec000 b5cff000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d10000 b5d4a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d5b000 b5d69000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d79000 b5d81000 r-xp /usr/lib/libtbm.so.1.0.0
b5d91000 b5d9e000 r-xp /usr/lib/libeio.so.1.13.0
b5dae000 b5db0000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dc0000 b5dc5000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd5000 b5dec000 r-xp /usr/lib/libefreet.so.1.13.0
b5dfe000 b5e1e000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e2e000 b5e4e000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e50000 b5e56000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e66000 b5e77000 r-xp /usr/lib/libemotion.so.1.13.0
b5e88000 b5e8f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e9f000 b5eae000 r-xp /usr/lib/libeo.so.1.13.0
b5ebf000 b5ed1000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ee2000 b5ee7000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ef7000 b5f10000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f20000 b5f3d000 r-xp /usr/lib/libeet.so.1.13.0
b5f56000 b5f9e000 r-xp /usr/lib/libeina.so.1.13.0
b5faf000 b5fbf000 r-xp /usr/lib/libefl.so.1.13.0
b5fd0000 b60b5000 r-xp /usr/lib/libicuuc.so.51.1
b60d2000 b6212000 r-xp /usr/lib/libicui18n.so.51.1
b6229000 b6261000 r-xp /usr/lib/libecore_x.so.1.13.0
b6273000 b6276000 r-xp /lib/libcap.so.2.21
b6286000 b62af000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62c0000 b62c7000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62d9000 b6310000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6321000 b640c000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b641f000 b6498000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64aa000 b64af000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64bf000 b64c9000 r-xp /usr/lib/libvconf.so.0.2.45
b64d9000 b64db000 r-xp /usr/lib/libvasum.so.0.3.1
b64eb000 b64ed000 r-xp /usr/lib/libttrace.so.1.1
b64fd000 b6500000 r-xp /usr/lib/libiniparser.so.0
b6510000 b6536000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6546000 b654b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b655c000 b6573000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6584000 b65ef000 r-xp /lib/libm-2.20-2014.11.so
b6600000 b6606000 r-xp /lib/librt-2.20-2014.11.so
b6617000 b6624000 r-xp /usr/lib/libunwind.so.8.0.1
b665a000 b677e000 r-xp /lib/libc-2.20-2014.11.so
b6793000 b67ac000 r-xp /lib/libgcc_s-4.9.so.1
b67bc000 b689e000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68af000 b68d9000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ea000 b6926000 r-xp /usr/lib/libsystemd.so.0.4.0
b6928000 b69ab000 r-xp /usr/lib/libedje.so.1.13.0
b69be000 b69dc000 r-xp /usr/lib/libecore.so.1.13.0
b69fc000 b6b83000 r-xp /usr/lib/libevas.so.1.13.0
b6bb8000 b6bcc000 r-xp /lib/libpthread-2.20-2014.11.so
b6be0000 b6e14000 r-xp /usr/lib/libelementary.so.1.13.0
b6e43000 b6e47000 r-xp /usr/lib/libsmack.so.1.0.0
b6e57000 b6e5e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e6e000 b6e70000 r-xp /usr/lib/libdlog.so.0.0.0
b6e80000 b6e83000 r-xp /usr/lib/libbundle.so.0.1.22
b6e93000 b6e95000 r-xp /lib/libdl-2.20-2014.11.so
b6ea6000 b6ebe000 r-xp /usr/lib/libaul.so.0.1.0
b6ed2000 b6ed7000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ee8000 b6ef5000 r-xp /usr/lib/liblptcp.so
b6f07000 b6f0b000 r-xp /usr/lib/libsys-assert.so
b6f1c000 b6f3c000 r-xp /lib/ld-2.20-2014.11.so
b6f4d000 b6f52000 r-xp /usr/bin/launchpad-loader
b8bad000 b8df2000 rw-p [heap]
beae8000 beb09000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20283)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6685b84) [/lib/libc.so.6] + 0x2bb84
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
06-13 14:18:06.347+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:18:06.347+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:18:06.347+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:18:06.347+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:18:06.347+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:18:06.347+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:18:06.547+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-13 14:18:06.547+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-13 14:18:06.547+0900 W/APP_CORE(  857): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-13 14:18:06.547+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: RESUME State: PAUSED
06-13 14:18:06.547+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:18:06.547+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-13 14:18:06.547+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-13 14:18:06.547+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 14:18:06.557+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-13 14:18:06.557+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:18:06.567+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 857
06-13 14:18:06.567+0900 I/AUL_AMD (  607): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-13 14:18:06.577+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:18:06.577+0900 W/AUL_AMD (  607): amd_launch.c: start_process(638) > child process: 20526
06-13 14:18:06.627+0900 W/AUL_AMD (  607): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 20526
06-13 14:18:06.627+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20526, appid: com.samsung.weather-m-agent
06-13 14:18:06.637+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20526)
06-13 14:18:06.647+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-13 14:18:06.647+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 20526.
06-13 14:18:06.807+0900 E/weather-agent(20526): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-13 14:18:06.807+0900 E/weather-common(20526): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-13 14:18:06.817+0900 E/weather-agent(20526): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-13 14:18:06.817+0900 E/weather-common(20526): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-13 14:18:06.817+0900 E/weather-common(20526): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-13 14:18:06.817+0900 E/weather-common(20526): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-13 14:18:06.817+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-13 14:18:06.817+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-13 14:18:06.817+0900 I/MESSAGE_PORT(20526): message-port.c: __initialize(872) > initialize
06-13 14:18:06.827+0900 I/MESSAGE_PORT(20526): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:18:06.857+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:18:06.857+0900 E/MESSAGE_PORT(20526): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-13 14:18:06.857+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-13 14:18:06.857+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:18:06.867+0900 I/MESSAGE_PORT(  857): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:18:06.867+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:18:06.867+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:18:06.867+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:18:06.867+0900 I/MESSAGE_PORT(20526): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:18:06.867+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-13 14:18:06.867+0900 I/MESSAGE_PORT(20526): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-13 14:18:06.867+0900 I/MESSAGE_PORT(20526): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:18:06.867+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:18:06.867+0900 I/MESSAGE_PORT( 1324): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:18:06.867+0900 E/MESSAGE_PORT(20526): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-13 14:18:06.867+0900 E/weather-common(20526): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-13 14:18:06.867+0900 E/weather-agent(20526): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-13 14:18:06.867+0900 E/weather-agent(20526): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-13 14:18:06.867+0900 I/MESSAGE_PORT(20526): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:18:06.867+0900 I/MESSAGE_PORT(20526): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:18:06.877+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:18:06.897+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:18:06.927+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:18:06.937+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:18:06.937+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:18:06.937+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:18:06.937+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:18:06.937+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:18:06.937+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_update_cb(287) > received updating signal
06-13 14:18:06.967+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18073168
06-13 14:18:06.967+0900 I/Tizen::System( 1175): (280) > The screen has been turned on.
06-13 14:18:06.967+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:18:06.987+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-13 14:18:06.987+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:18:07.007+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:18:07.017+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:07.017+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:18:07.017+0900 I/CAPI_WIDGET_APPLICATION( 1355): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:18:07.017+0900 W/AUL     ( 1355): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1355, appid: live-com.samsung.browser, status: fg
06-13 14:18:07.027+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:07.027+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:07.067+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18073279
06-13 14:18:07.077+0900 E/LOCKSCREEN(  857): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-13 14:18:07.077+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-13 14:18:07.077+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-13 14:18:07.077+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:18:07.077+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-13 14:18:07.077+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-13 14:18:07.077+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-13 14:18:07.077+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-13 14:18:07.077+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-13 14:18:07.077+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-13 14:18:07.077+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:18:07.398+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-13 14:18:07.398+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-13 14:18:07.408+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-13 14:18:07.408+0900 E/LOCKSCREEN(  857): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-13 14:18:07.408+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:18:07.408+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:18:07.408+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:18:07.408+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:18:07.408+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 14:18:07.408+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:07.418+0900 W/LOCKSCREEN(  857): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-13 14:18:07.418+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-13 14:18:07.418+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-13 14:18:07.418+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:18:07.418+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:18:07.418+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:18:07.418+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:18:07.418+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(857) status(4)
06-13 14:18:07.418+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(857)
06-13 14:18:07.418+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 857, appid: com.samsung.lockscreen, status: bg
06-13 14:18:07.428+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:18:07.428+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:18:07.428+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:18:07.428+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:18:07.428+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:18:07.438+0900 E/LOCKSCREEN(  857): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-13 14:18:07.438+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: PAUSE State: RUNNING
06-13 14:18:07.438+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:18:07.438+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:18:07.438+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:18:07.438+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-13 14:18:07.438+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-13 14:18:07.438+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:18:07.438+0900 E/LOCKSCREEN(  857): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-13 14:18:07.468+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:18:07.488+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:18:07.488+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:18:07.508+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:18:07.538+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-13 14:18:07.538+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:18:07.538+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:18:07.538+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:18:07.538+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:18:07.538+0900 E/LOCKSCREEN(  857): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-13 14:18:07.858+0900 E/weather-agent(20526): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-13 14:18:07.858+0900 I/CAPI_APPFW_APPLICATION(20526): service_app_main.c: service_app_exit(446) > service_app_exit
06-13 14:18:07.858+0900 E/weather-agent(20526): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-13 14:18:07.858+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:18:07.858+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:18:07.998+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 14:18:07.998+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 20526
06-13 14:18:07.998+0900 I/Tizen::App( 1175): (243) > App[com.samsung.weather-m-agent] pid[20526] terminate event is forwarded
06-13 14:18:07.998+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:18:07.998+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 20526, ]
06-13 14:18:07.998+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:18:07.998+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-13 14:18:07.998+0900 I/Tizen::App( 1175): (512) > Not registered pid(20526)
06-13 14:18:07.998+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.weather-m-agent]
06-13 14:18:07.998+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:18:07.998+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 20526
06-13 14:18:08.008+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:18:08.008+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 20526.
06-13 14:18:08.018+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.018+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.038+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.048+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.058+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.058+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.078+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.078+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.098+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.098+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.118+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.118+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.138+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.138+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.158+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.158+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.158+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.158+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.178+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.178+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.198+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.198+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.208+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.218+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:08.228+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-13 14:18:08.238+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:18:12.443+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:18:12.873+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:18:15.536+0900 E/PKGMGR_SERVER(20568): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:18:15.586+0900 E/PKGMGR  (20566): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-13 14:18:15.626+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:18:15.626+0900 E/AUL_AMD (  607): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 20460
06-13 14:18:15.636+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:18:15.646+0900 E/PKGMGR_SERVER(20568): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20571]
06-13 14:18:17.788+0900 E/PKGMGR_SERVER(20568): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:18:17.788+0900 E/PKGMGR_SERVER(20568): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:18:20.460+0900 E/PKGMGR  (20656): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
06-13 14:18:20.540+0900 E/PKGMGR_SERVER(20658): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:18:20.600+0900 E/PKGMGR_SERVER(20658): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
06-13 14:18:20.610+0900 E/PKGMGR_SERVER(20658): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
06-13 14:18:20.610+0900 E/PKGMGR  (20656): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[206560002]
06-13 14:18:20.771+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
06-13 14:18:20.771+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
06-13 14:18:20.771+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:20.771+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:20.771+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-13 14:18:20.781+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:18:20.781+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:18:20.781+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-13 14:18:20.781+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:20.781+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:21.071+0900 E/rpm-installer(20661): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-13 14:18:21.071+0900 E/rpm-installer(20661): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-13 14:18:21.121+0900 E/PKGMGR_PARSER(20661): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-13 14:18:21.141+0900 I/PRIVACY-MANAGER-CLIENT(20661): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:18:21.141+0900 I/PRIVACY-MANAGER-CLIENT(20661): SocketClient.cpp: connect(62) > Client connected
06-13 14:18:21.141+0900 I/PRIVACY-MANAGER-SERVER(  914): SocketService.cpp: mainloop(230) > Got incoming connection
06-13 14:18:21.141+0900 I/PRIVACY-MANAGER-CLIENT(20661): SocketClient.cpp: disconnect(72) > Client disconnected
06-13 14:18:21.151+0900 E/PKGMGR_CERT(20661): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-13 14:18:21.151+0900 E/PKGMGR_CERT(20661): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-13 14:18:21.161+0900 E/PKGMGR_CERT(20661): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-13 14:18:21.191+0900 E/rpm-installer(20661): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-13 14:18:21.201+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-13 14:18:21.201+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
06-13 14:18:21.201+0900 E/ESD     (  898): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-13 14:18:21.211+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-13 14:18:21.211+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:21.211+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:21.211+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-13 14:18:21.221+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-13 14:18:22.793+0900 E/PKGMGR_SERVER(20658): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:18:22.873+0900 E/PKGMGR_SERVER(20658): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20661]
06-13 14:18:24.795+0900 E/PKGMGR_SERVER(20658): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:18:24.795+0900 E/PKGMGR_SERVER(20658): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:18:25.345+0900 E/PKGMGR  (20710): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-13 14:18:25.425+0900 E/PKGMGR_SERVER(20712): pkgmgr-server.c: main(2414) > package manager server start
06-13 14:18:25.485+0900 E/PKGMGR_SERVER(20712): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-13 14:18:25.495+0900 E/PKGMGR_INFO(20712): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-13 14:18:25.505+0900 E/rpm-installer(20712): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-13 14:18:25.505+0900 E/PKGMGR_SERVER(20712): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-13 14:18:25.515+0900 E/PKGMGR  (20710): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[207100002]
06-13 14:18:25.635+0900 E/PKGMGR_INSTALLER(20715): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-13 14:18:25.635+0900 E/rpm-installer(20715): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-13 14:18:25.645+0900 E/rpm-installer(20715): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-13 14:18:25.645+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-13 14:18:25.655+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:18:25.655+0900 E/rpm-installer(20715): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-13 14:18:25.655+0900 E/rpm-installer(20715): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:18:25.756+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-13 14:18:25.756+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
06-13 14:18:25.756+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:25.756+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:25.766+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 14:18:25.766+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 14:18:25.766+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-13 14:18:25.766+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:25.766+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:26.036+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-13 14:18:26.046+0900 E/rpm-installer(20715): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-13 14:18:26.046+0900 E/PKGMGR_PARSER(20715): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-13 14:18:26.056+0900 E/PKGMGR_PARSER(20715): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-13 14:18:26.086+0900 I/PRIVACY-MANAGER-CLIENT(20715): SocketClient.cpp: SocketClient(37) > Client created
06-13 14:18:26.296+0900 E/PKGMGR_PARSER(20715): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-13 14:18:26.316+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-13 14:18:26.316+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 1
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 2
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 2
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 1
06-13 14:18:26.326+0900 E/PKGMGR_CERT(20715): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-13 14:18:26.336+0900 E/rpm-installer(20715): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.client/lib]
06-13 14:18:26.336+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:26.336+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-13 14:18:26.336+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:26.336+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [60]
06-13 14:18:26.336+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
06-13 14:18:26.346+0900 E/rpm-installer(20715): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 14:18:26.366+0900 E/rpm-installer(20715): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-13 14:18:26.376+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-13 14:18:26.376+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [100]
06-13 14:18:26.376+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
06-13 14:18:26.376+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:26.376+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:27.798+0900 E/PKGMGR_SERVER(20712): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 14:18:28.198+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 14:18:28.198+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 14:18:28.198+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 14:18:28.208+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 14:18:28.208+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 14:18:28.208+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 14:18:28.228+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:28.228+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:18:28.238+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 14:18:28.238+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 14:18:28.248+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 14:18:28.248+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 14:18:28.248+0900 E/PKGMGR_SERVER(20712): pkgmgr-server.c: sighandler(417) > child NORMAL exit [20715]
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:18:28.258+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 14:18:28.258+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-13 14:18:28.268+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 14:18:28.268+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 14:18:28.268+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 14:18:28.268+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (131) > Enter
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 14:18:28.278+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 14:18:28.288+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 14:18:28.318+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:18:29.789+0900 E/PKGMGR_SERVER(20712): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:18:29.789+0900 E/PKGMGR_SERVER(20712): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:18:30.460+0900 I/Tizen::System( 1175): (458) > org.tizen.system.deviced.display - CurrentBrightness (0)
06-13 14:18:32.522+0900 W/AUL     (20770): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:18:32.522+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:18:32.532+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:18:32.542+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:18:32.542+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:18:32.542+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 20770
06-13 14:18:32.542+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:18:32.552+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 7
06-13 14:18:32.552+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:18:32.552+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:18:32.552+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:18:32.552+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:18:32.572+0900 I/abc     (20283): abc
06-13 14:18:32.572+0900 I/CAPI_APPFW_APPLICATION(20283): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:18:32.572+0900 I/CAPI_APPFW_APPLICATION(20283): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:18:32.602+0900 E/TBM     (20283): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:18:32.652+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 20283, appid: org.example.client
06-13 14:18:32.662+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:18:32.672+0900 W/AUL     (20770): launch.c: app_request_to_launchpad(425) > request cmd(0) result(20283)
06-13 14:18:32.862+0900 W/CRASH_MANAGER(20783): worker.c: worker_job(1199) > 0620283636c69149733111
